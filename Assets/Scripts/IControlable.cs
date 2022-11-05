using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IControlable : MonoBehaviour
{
    public abstract void Rotate(float RotationVelocity);
    public abstract void RotateShaft(float RotationVelocity, float DrivenGearRadius);
}
