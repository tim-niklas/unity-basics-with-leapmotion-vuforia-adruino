using UnityEngine;
using System.IO.Ports; // Need for Arduino Connection



public class ArduinoBehaviour : MonoBehaviour
{
    // First parameter is the COM-Port the arduino is connected
    // if you not sure which COM-Port, look into the device-manager on your computer
    // if your using a Mac you need to set the full Path to the serial instead of „COM3“
    // the second parameter is the port to listen
    SerialPort sp = new SerialPort("COM3", 9600);
    // Use this for initialization

    //Rotate Angle
    public float rotateAngle;
    public Quaternion targetRotation;
    public Rigidbody rb;
    public float thrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Opening the Port, once open this port is blocked for other applications
        if (!sp.IsOpen)
            sp.Open();
    }
    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
            Debug.Log(sp.ReadLine());

        // if forward transform.position += transform.forward * Time.deltaTime * 5;

        
        /* if not standsill
         * 
         * if right rotateAngle += 1 * rotateSpeed;
         * 
         * if left  rotateAngle += -1 * rotateSpeed;
         * 
                 Vector3 targetDirection = new Vector3(Mathf.Sin(rotateAngle), 0, Mathf.Cos(rotateAngle));
                targetRotation = Quaternion.LookRotation(targetDirection);

                transform.rotation = targetRotation;
        */

        // if jump rb.AddForce(transform.up * thrust);
    }
    void OnApplicationQuit()
    {
        // Make sure to close the port in the end
        if (sp.IsOpen)
            sp.Close();
    }
}


