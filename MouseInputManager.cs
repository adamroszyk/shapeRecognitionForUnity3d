using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Class that handles the mouse inputs and triggers drawing the shape
/// </summary>
public class MouseInputManager : MonoBehaviour
{
    public Shape _currentlyDrawnShape;

    public MouseButtonState CurrentMouseState
    {
        get { return _currentMouseState; }
        set
        {
            if (value == MouseButtonState.OnButtonDown)
            {
                _currentMouseState = MouseButtonState.OnButtonDown;
                InitializeShapeDrawing();
            }
            else if (value == MouseButtonState.OnButtonUp)
            {
                _currentMouseState = MouseButtonState.OnButtonUp;
                FinishShapeDrawing();
            }
        }
    }
    private MouseButtonState _currentMouseState;


    void InitializeShapeDrawing()
    {
        ClearPreviousLine();
        _currentlyDrawnShape = new Shape(RayCast());
    }

    private void ContinueDrawing()
    {
        _currentlyDrawnShape.KeepDrawing(RayCast());
    }

    private void FinishShapeDrawing()
    {
        _currentlyDrawnShape.Compare();
    }

    void Update()
    {
        CheckMouseInput();
    }

    #region helpers
    private void CheckMouseInput()
    {
        if (Input.GetMouseButtonDown(0) == true) CurrentMouseState = MouseButtonState.OnButtonDown;
        if (Input.GetMouseButton(0) == true){
            ContinueDrawing();
            CurrentMouseState = MouseButtonState.OnButtonHold;}
        if (Input.GetMouseButtonUp(0) == true) CurrentMouseState = MouseButtonState.OnButtonUp;
    }

    private Vector3 RayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Transform objectHit = hit.transform;
        }
        return hit.point;
    }

    private void ClearPreviousLine()
    {
        if (_currentlyDrawnShape != null ) Destroy(_currentlyDrawnShape._shapeGameObject);
    }
    #endregion

    #region Enums
    public enum MouseButtonState
    {
        OnButtonDown = 0,
        OnButtonHold = 1,
        OnButtonUp = 2
    }
    #endregion    
}