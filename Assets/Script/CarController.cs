using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum WheelType
{ 
    FrontRight,
    FrontLeft,
    BackRight,
    BackLeft
}


public class CarController : MonoBehaviour
{
    public float motorForce;
    public float brakeForce;
    public float maxSteerAngle;

    [EnumNamedArray(typeof(WheelType))]
    public WheelCollider[] wheelColliders = new WheelCollider[Enum.GetValues(typeof(WheelType)).Length];

    [EnumNamedArray(typeof(WheelType))]
    public Transform[] wheelTransforms = new Transform[Enum.GetValues(typeof(WheelType)).Length];

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentBrackForce;
    private bool isBraking;

    private void Update()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        isBraking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        wheelColliders[(int)WheelType.FrontLeft].motorTorque = verticalInput * motorForce;
        wheelColliders[(int)WheelType.FrontRight].motorTorque = verticalInput * motorForce;

        wheelColliders[(int)WheelType.BackRight].motorTorque = verticalInput * (motorForce / 5f);
        wheelColliders[(int)WheelType.BackLeft].motorTorque = verticalInput * (motorForce / 5f);

        currentBrackForce = isBraking ? brakeForce : 0;
        ApplyBraking();
    }

    public void ApplyBraking()
    {
        wheelColliders[(int)WheelType.FrontLeft].brakeTorque = currentBrackForce;
        wheelColliders[(int)WheelType.FrontRight].brakeTorque = currentBrackForce;
        wheelColliders[(int)WheelType.BackRight].brakeTorque = currentBrackForce;
        wheelColliders[(int)WheelType.BackLeft].brakeTorque = currentBrackForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;

        wheelColliders[(int)WheelType.FrontLeft].steerAngle = currentSteerAngle;
        wheelColliders[(int)WheelType.FrontRight].steerAngle = currentSteerAngle;
    }

    private void UpdateSingleWheel(WheelCollider collider, Transform transform)
    {
        Vector3 pos;
        Quaternion rot;

        collider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }

    private void UpdateWheels()
    {
        for (int i = 0; i < wheelColliders.Length; i++)
        {
            UpdateSingleWheel(wheelColliders[i], wheelTransforms[i]);
        }
    }

    public void SlowMotorForce(float mul)
    {
        motorForce /= mul;
    }

    public void PaceUpMotorForce(float mul)
    {
        motorForce *= mul;
    }
}
