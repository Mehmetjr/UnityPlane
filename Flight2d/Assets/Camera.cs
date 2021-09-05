using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform plane;
    public float cameraXValue;
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(plane.position.x + cameraXValue, 0, -10);
    }
}
