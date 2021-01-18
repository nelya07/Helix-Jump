using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //[SerializeField] private FinishPlatform _finishPlatform;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlatformSegment platformSegment))
        {
            other.GetComponentInParent<Platform>().Break(); 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out FinishPlatform finishPlatform))
        {
            Debug.Log("Congratulations! You are winner!"); 
        }     
    }
}
