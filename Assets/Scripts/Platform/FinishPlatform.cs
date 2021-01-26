using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : Platform
{
    private bool _isGameFinished = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (!_isGameFinished && collision.gameObject.TryGetComponent(out Ball _ball))
        {
            _isGameFinished = true;
            Debug.Log("Congratulations! You are winner! ${name}");
        }
    }
}

