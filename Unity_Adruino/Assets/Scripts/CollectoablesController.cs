﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectoablesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the Collectables

        if (Time.timeScale == 1)
        {
            transform.rotation *= Quaternion.Euler(1,
                                               1,
                                               1);
        }
    }

}
