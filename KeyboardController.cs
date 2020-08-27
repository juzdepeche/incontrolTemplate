using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyboardControllerSide
{
    Left,
    Right
}

public class KeyboardController : IInputController
{
    string guid;
    KeyboardControllerSide side;
    string xAxis;
    string yAxis;

    public KeyboardController(KeyboardControllerSide _side)
    {
        side = _side;
        guid = isLeft() ? "left" : "right";

		string suffix = isLeft() ? "1" : "2";
        xAxis = "Horizontal" + suffix;
        yAxis = "Vertical" + suffix; 

        Debug.Log("<color=green>New controller registered!</color> (" + Guid() + ").");
    }

	public bool Action1WasPressed()
	{
		return isLeft() ? Input.GetKeyDown(KeyCode.Space) : Input.GetKeyDown(KeyCode.KeypadEnter);
	}

	public bool Action2WasPressed()
	{
		throw new System.NotImplementedException();
	}

	public bool Action3WasPressed()
	{
		throw new System.NotImplementedException();
	}

	public bool Action4WasPressed()
	{
		throw new System.NotImplementedException();
	}

	public Vector2 GetAxis()
	{
		return new Vector2(Input.GetAxis(xAxis), Input.GetAxis(yAxis));
	}

	public string Guid()
	{
		return guid;
	}

	private bool isLeft()
    {
        return side == KeyboardControllerSide.Left;
    }
}
