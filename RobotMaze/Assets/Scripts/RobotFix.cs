using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFix : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Transform robotTransform = GetComponent<Transform>();

            Vector3 newRotation = robotTransform.rotation.eulerAngles;
            newRotation.z = 0f;
            robotTransform.rotation = Quaternion.Euler(newRotation);

            Vector3 newPosition = robotTransform.position;
           newPosition.y = -184.0338f;
           robotTransform.position = newPosition;
        }
    }
}
