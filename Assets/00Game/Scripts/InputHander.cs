using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHander : MonoBehaviour
{
    public event Action OnKeyLeft;
    public event Action OnKeyRight;
    public event Action OnKeyJump;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("cc");
            //OnKeyLeft?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnKeyRight?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnKeyJump?.Invoke();
        }
    }
}
