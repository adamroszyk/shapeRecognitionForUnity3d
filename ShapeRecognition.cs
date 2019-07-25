using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class ShapeRecognition
{
    public ModelsTemplates _models;
    public Shape _currentShape;
    public TextMesh _gui;
    public int descriptorsAmount=50;

    /// <summary>
    /// The goal is to simplify drawn shape to fewer points and translate them to lists of Vectors and Angles describing relationships between points.
    /// </summary>
    public ShapeRecognition(Shape currentlyDrawnShape)
    {        
        _models = new ModelsTemplates();
        _currentShape = currentlyDrawnShape;
        ShapeSimplification(currentlyDrawnShape, descriptorsAmount);
        _currentShape._angles=CalculateAnglesBetweenPoints();
        _currentShape._distances=CalculateDistanceBetweenPoints();
       CompareToModels(_currentShape, _models.allModels);
    }

    /// <summary>
    /// Simple function that unifies the size of descriptors list, and select the most important points for the figure.
    /// </summary>
    /// <param name="targetSize">How many points do you want to have in simplified model</param>
    private void ShapeSimplification( Shape shapeToSimplify, int targetSize)
    {
        float interval = CalculateShapeLength(shapeToSimplify._points) / targetSize;
        float distance = 0;
        int cnt = 0;
        List<Vector3> simplifiedPoints = new List<Vector3>();
        for (int i = 1; i <= shapeToSimplify._points.Count-1; i++) {
            if (Vector3.Distance(shapeToSimplify._points[i], shapeToSimplify._points[i - 1]) + distance > interval)
            {
                simplifiedPoints.Add(shapeToSimplify._points[i]);
                distance = 0;
                cnt++;
            }
            else distance += Vector3.Distance(shapeToSimplify._points[i], shapeToSimplify._points[i - 1]);
        }
        _currentShape._pointsSimplfied = simplifiedPoints;
    }
    

    public List<float> CalculateAnglesBetweenPoints() {
        List<float> angles = new List<float>();
        for (int i = 1; i <= _currentShape._pointsSimplfied.Count - 1; i++) {
            angles.Add(Vector3.SignedAngle(_currentShape._pointsSimplfied[i], _currentShape._pointsSimplfied[i-1],Vector3.back));
        }
        //Useful code for creating new data models for ModelData.cs
        /*
        Debug.Log("\n angels " + String.Join("f,  ",
             new List<float>(angles)
             .ConvertAll(i => i.ToString())
             .ToArray()));*/
        return angles;   
    }

    public List<Vector3> CalculateDistanceBetweenPoints() {
        List<Vector3> distances = new List<Vector3>();
        for (int i = 1; i <= _currentShape._pointsSimplfied.Count - 1; i++)
        {
            Vector3 delta;
            delta = (_currentShape._pointsSimplfied[i - 1] - _currentShape._pointsSimplfied[i]);
            distances.Add(delta);
        }
        //Useful code for creating new data models for ModelData.cs
        /*
          Debug.Log("new Vector3" + String.Join(",new Vector3  ",
               new List<Vector3>(distances)
               .ConvertAll(i => i.ToString())
               .ToArray()));*/
        return distances;
    }

    /// <summary>
    /// Method for comparing drawn shape to models saved in ModelData.cs
    /// </summary>
    /// <param name="shapeSimplified">Currently drawn shape</param>
    /// <param name="allModels">List of list with all models templates</param>
    private void CompareToModels(Shape shapeSimplified, List<List<Vector3>> allModels)
    {
        int cnt=0;
        int bestMatch=9999;
        int recognisedModel=0;
        foreach (List<Vector3> list in allModels)
        {
           // float angleValue = 0;   // Current version only supports distance based comparasion.
            float distanceValueX = 0;
            float distanceValueY = 0;
            for (int i = 0; i <= shapeSimplified._distances.Count-1; i++)
            {
                if (shapeSimplified._angles.Count > i && list.Count>i)
                {
                    distanceValueX += (list[i].x - shapeSimplified._distances[i].x);
                    distanceValueY += (list[i].y - shapeSimplified._distances[i].y);
                }
            }
            if (Mathf.Abs((int)(distanceValueX * distanceValueY)) < bestMatch)
            {
                bestMatch=Mathf.Abs((int)(distanceValueX * distanceValueY));
                recognisedModel = cnt;
            }
            cnt++;
        }       
       _gui = GameObject.Find("Text").GetComponent<TextMesh>();
       _gui.text=""+_models.allModelNames[recognisedModel];
    }



    //Handling different scales, positions and rotations - To be implemented in the future.
    public void ScaleGesture() { }
    public void RotateGesture() { }
    public void RepositionGesture() { }
    
    #region helper functions
    static float CalculateShapeLength(List<Vector3> pointArray)
    {
        float length = 0.0f;
        for (int i = 1; i < pointArray.Count; ++i)
        {
            length += Vector3.Distance(pointArray[i - 1], pointArray[i]);
        }
        return length;
    }
    #endregion
}

public class SimplifiedModel
{
    public List<Vector3> originalPoints;
    public List<Vector3> pointsSimplfied;
    public List<float> angles;
    public List<float> distances;
}