using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    //target which the camera follows..
    public Transform target;
    
    
    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
