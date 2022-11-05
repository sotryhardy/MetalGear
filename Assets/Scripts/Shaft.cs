using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaft : MonoBehaviour
{
    public Gear DriveGear;
    public Gear DrivenGear;
    public GameObject Axis;
    public Shaft DrivenElement;
    public  void Rotate(float RotationVelocity, float DrivenGearRadius = 0f)
    {
        float ResoltVelocyti = RotationVelocity;
        if (DrivenGearRadius != 0)
        {
            ResoltVelocyti *= DrivenGearRadius / DriveGear.radius;
        }
        gameObject.transform.Rotate(ResoltVelocyti, 0, 0);
        if (DrivenElement)
            DrivenElement.Rotate(ResoltVelocyti, DrivenGear.radius);
        //DrivenElement.RotateShaft(RotationVelocity, DrivenGear.radius);
    }

    //private  void RotateShaft(float RotationVelocity, float DrivenGearRadius)
    //{
    //    gameObject.transform.Rotate(RotationVelocity * (DrivenGearRadius / DriveGear.radius), 0, 0);
    //    DrivenElement.Rotate();
    //}
}
