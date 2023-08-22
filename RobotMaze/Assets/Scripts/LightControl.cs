using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public Light spotlight;
    private bool isLightActive = false;

    void Start()
    {
            spotlight.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isLightActive = !isLightActive;
            spotlight.enabled = isLightActive;
        }
    }
}