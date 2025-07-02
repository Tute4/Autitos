using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform centerOfMass;
    public float motorTorque = 1500f;
    public float maxSteer = 20f;

    public float Steer { get; set; }
    public float Throttle { get; set; }

    private Rigidbody _rigibody;
    private Wheel[] wheels;

    void Start()
    {
        wheels = GetComponentsInChildren<Wheel>();
        _rigibody = GetComponent<Rigidbody>();
        _rigibody.centerOfMass = centerOfMass.localPosition;
    }



    void Update()
    {
        foreach (var wheel in wheels)
        {
            wheel.SteerAngle = Steer * maxSteer;
            wheel.Torque = Throttle * motorTorque;
        }
    }
}