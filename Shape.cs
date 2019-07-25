using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Shape
{
    public LineRenderer _lRend;
    public GameObject _shapeGameObject;
    public List<Vector3> _points = new List<Vector3>();
    public List<Vector3> _pointsSimplfied = new List<Vector3>();
    public List<float> _angles;
    public List<Vector3> _distances;

    public Shape(Vector3 vector3)
    {
        _shapeGameObject = new GameObject("CurrentlyDrawnShape");
        _lRend = _shapeGameObject.AddComponent<LineRenderer>();
        _lRend.material = new Material(Shader.Find("Mobile/Particles/Additive"));
        _lRend.startWidth = .1f;
        _lRend.endWidth = .1f;
        _lRend.SetPosition(0, vector3);
        _lRend.SetPosition(1, vector3);
    }

    internal void KeepDrawing(Vector3 newPos)
    {        
        _lRend.positionCount++;
        _lRend.SetPosition(_lRend.positionCount - 1, newPos);
        _points.Add(newPos);
    }

    public void Compare()
    {
        ShapeRecognition recogniser = new ShapeRecognition(this);
    }
}
