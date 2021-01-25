using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball _ball))
        {
            Debug.Log("Congratulations! You are winner!");
        }
    }
}

