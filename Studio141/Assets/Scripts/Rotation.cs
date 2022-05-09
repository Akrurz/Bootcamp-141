using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
  
 float rotationX=0f;
  float rotationY=1f;
float rotationZ=0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360*rotationX*Time.deltaTime,360*rotationY*Time.deltaTime,360*rotationZ*Time.deltaTime );
    }
}
