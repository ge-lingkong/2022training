using System;
using UnityEngine;

public class Clock: MonoBehaviour{
    [SerializeField] Transform hourAngle, minuteAngle, secondAngle;
    void Update()
    {
        int h = DateTime.Now.Hour, m = DateTime.Now.Minute, s = DateTime.Now.Second;
        hourAngle.localRotation = Quaternion.Euler(0, 0, -30 * h);
        minuteAngle.localRotation = Quaternion.Euler(0, 0, -6 * m);
        secondAngle.localRotation = Quaternion.Euler(0, 0, -6 * s);
    }
}