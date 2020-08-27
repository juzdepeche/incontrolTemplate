using System.Collections;
using System.Collections.Generic;
using InControl;
using UnityEngine;

public class DeviceController : IInputController
{
    InputDevice device;
    public DeviceController(InputDevice _device)
    {
       device = _device;
       Debug.Log("<color=green>New controller registered!</color> (" + Guid() + ").");
    }

	public bool Action1WasPressed()
	{
		return device.Action1.WasPressed;
	}

	public bool Action2WasPressed()
	{
		return device.Action2.WasPressed;
	}

	public bool Action3WasPressed()
	{
		return device.Action3.WasPressed;
	}

	public bool Action4WasPressed()
	{
		return device.Action4.WasPressed;
	}

	public Vector2 GetAxis()
	{
		return new Vector2(device.LeftStickX, device.LeftStickY);
	}

	public string Guid()
	{
		return device.GUID.ToString();
	}
}
