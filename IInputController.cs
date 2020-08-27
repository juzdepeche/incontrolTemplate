using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputController
{
    bool Action1WasPressed();
    bool Action2WasPressed();
    bool Action3WasPressed();
    bool Action4WasPressed();
    Vector2 GetAxis();
    string Guid();
}
