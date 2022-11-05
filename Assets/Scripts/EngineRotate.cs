using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineRotate : MonoBehaviour
{

    public float RotationVelocity = 0;
    public FlyWheel FlyWheel;

    void Update()
    {
        //Vector3 vec = FlyWheel.transform.localEulerAngles;
        //vec.z += RotationVelocity * Time.deltaTime;
        //FlyWheel.transform.localEulerAngles = vec;
        FlyWheel.Rotate(RotationVelocity * Time.deltaTime);
    }

   
}
