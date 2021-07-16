using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject wheel_FR;
    public GameObject wheel_FL;
    public GameObject wheel_BR;
    public GameObject wheel_BL;

    public WheelCollider FR;
    public WheelCollider FL;
    public WheelCollider BR;
    public WheelCollider BL;

    

    public float Torque = 1000f;

    public float loweststeerspeed = 40f;
    public float loweststeerangle = 70f;
    public float higheststeerangle = 40f;

    Rigidbody rb;
    Vector3 temp;
    Vector3 temp1;

    public bool isbrake = false;
    public float brakeTorque = 1000f;

       

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        temp = rb.centerOfMass;
        temp.x = 0f;
        temp.y = -0.8f;
        temp.z = 0f;
        rb.centerOfMass = temp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Move_Car();
        Steer_Wheels();
        Rotate_Wheels();
        Brake();
        
    }

    void Move_Car()
    {
        BR.motorTorque = 1000 * Input.GetAxis("Vertical");
        BL.motorTorque = 1000 * Input.GetAxis("Vertical");

        float speedfactor = this.GetComponent<Rigidbody>().velocity.magnitude / loweststeerspeed;
        float currentsteerangle = Mathf.Lerp(loweststeerangle, higheststeerangle, speedfactor);

        currentsteerangle *= Input.GetAxis("Horizontal");

        FR.steerAngle = currentsteerangle;
        FL.steerAngle = currentsteerangle;
    }

    void Steer_Wheels()
    {
        temp1 = wheel_FR.transform.localEulerAngles;
        temp1.y = FR.steerAngle;
        wheel_FR.transform.localEulerAngles = temp1;

        temp1 = wheel_FL.transform.localEulerAngles;
        temp1.y = FL.steerAngle;
        wheel_FL.transform.localEulerAngles = temp1;
    }

    void Rotate_Wheels()
    {
        
        wheel_BL.transform.Rotate(BL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheel_BR.transform.Rotate(BR.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    }

    void Brake()
    {
        if (Input.GetKey (KeyCode.Space)) { 
            isbrake = true;
          
        }
        else 
        {
            isbrake = false;
        }

        if (isbrake == true)
        {
            BR.brakeTorque = brakeTorque;
            BL.brakeTorque = brakeTorque;
            BR.motorTorque = 0;
            BL.motorTorque = 0;
            
        }
        else
        {
            BR.brakeTorque = 0;
            BL.brakeTorque = 0;
        }
    }

    
}
