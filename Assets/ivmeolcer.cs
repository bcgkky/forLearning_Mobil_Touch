﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivmeolcer : MonoBehaviour
{

    float speed = 15f;
    void FixedUpdate()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }
        dir *= Time.deltaTime;
        transform.Translate(dir*speed);
        
    }
}
