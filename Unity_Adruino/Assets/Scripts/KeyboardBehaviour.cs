﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardBehaviour : MonoBehaviour
{
    //Speed of Player
    public float movementSpeed = 5f;
    public float rotateSpeed = 0.1f;
    //Rotate Angle
    public float rotateAngle;
    public Quaternion targetRotation;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Movement forward and backward
        float moveVertical = Input.GetAxis("Vertical");    
        if (moveVertical > 0)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (moveVertical < 0)
        {
            transform.position += (transform.forward * -1) * Time.deltaTime * movementSpeed;
        }

        //Rotate Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        rotateAngle += moveHorizontal * rotateSpeed;
        Vector3 targetDirection = new Vector3(Mathf.Sin(rotateAngle), 0, Mathf.Cos(rotateAngle));
        targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = targetRotation;
        
    }
 
}