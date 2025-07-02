using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public string inputSteerAxis = "Horizontal";
    public string inputThrottelAxis = "Vertical";

    public float ThrottelInput { get; private set; }
    public float SteerInput { get; private set; }
    void Start()
    {

    }


    void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis);
        ThrottelInput = Input.GetAxis(inputThrottelAxis);
    }
}
