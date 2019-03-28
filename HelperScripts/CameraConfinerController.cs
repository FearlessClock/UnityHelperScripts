using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfinerController : MonoBehaviour
{
    private Vector3 currentPosition;
    [SerializeField] private Transform cameraTransform;
    private float confinerOffsetX;
    private void Start() {
        confinerOffsetX = this.transform.position.x;
        if(cameraTransform != null){
            this.transform.position = new Vector3(confinerOffsetX, cameraTransform.position.y, 0);
            currentPosition = this.transform.position;   
        }
    }

    public void OnJFHit(GameObject obj)
    {
        if(currentPosition.y < cameraTransform.position.y){
            if(cameraTransform != null){
                this.transform.position = new Vector3(confinerOffsetX, cameraTransform.position.y, 0);
                currentPosition = this.transform.position;   
            }
        }
    }
}
