using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarControllers : MonoBehaviour
{
    [Header("Wheels collider")]
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider frontRightWheelCollider;
    public WheelCollider backLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    
    [Header("Wheels Transform")]
    public Transform frontLeftWheelTransform; 
    public Transform frontRightWheelTransform;
    public Transform backLeftWheelTransform;
    public Transform backRightWheelTransform;

    [Header("Car Engine")]
    public float accelerationForce = 300f;
    public float breakingForce = 3000f;
    private float presentBreakForce = 0f;
    private float presentAcceleration = 0f;

    
    
    private void Update()
    {
        MoveCar();
    }
    
    private void MoveCar()
    {
        //AWD
        frontLeftWheelCollider.motorTorque = presentAcceleration;
        frontRightWheelCollider.motorTorque = presentAcceleration;
        backLeftWheelCollider.motorTorque = presentAcceleration;
        backRightWheelCollider.motorTorque = presentAcceleration;

        presentAcceleration = accelerationForce * Input.GetAxis("Vertical");
    }

    
  //  using UnityEngine;

// public class CarController : MonoBehaviour
// {
    public float speed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody carRigidbody;

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = transform.forward * moveVertical * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0f, moveHorizontal * rotationSpeed * Time.deltaTime, 0f);

        carRigidbody.MovePosition(transform.position + movement);
        carRigidbody.MoveRotation(carRigidbody.rotation * rotation);
    }
//}

}
