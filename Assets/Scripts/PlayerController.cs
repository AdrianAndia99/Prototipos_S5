using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Action OnMove;
    public Action OnJump;
    public Action OnRun;

    void Update()
    {
        OnMove?.Invoke();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            OnRun?.Invoke();
        }
    }
}
