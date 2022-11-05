using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWheel : MonoBehaviour
{
    public Clutch clutch;

    public void Rotate(float RotationVelocity)
    {
        gameObject.transform.Rotate(0, 0, RotationVelocity);
        clutch.Rotate(RotationVelocity);
    }
}
