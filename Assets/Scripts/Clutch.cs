using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clutch : MonoBehaviour
{
    public bool IsPressed = false;
    public Shaft DriveShaft;
    public void Rotate(float RotationVelocity)
    {
        gameObject.transform.Rotate( 0, RotationVelocity, 0);
        if(!IsPressed)
        {
            DriveShaft.Rotate(RotationVelocity);
        }
    }
}
