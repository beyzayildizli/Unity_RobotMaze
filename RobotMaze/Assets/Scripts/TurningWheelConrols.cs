using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningWheelConrols : MonoBehaviour
{
    public float speed = 0.1f;
    float x = 0f; 

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > 0)
        {
            x -= 0.1f ; 
        }
        else if (verticalInput < 0)
        {
            x += 0.1f; 
        }
        else
        {
            x = 0f;
        }
        this.transform.Rotate(speed * new Vector3(0, x, 0));
    }
}

