using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControls : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // sağ/sol dönüş
        float horizontalInput = Input.GetAxis("Horizontal");

        // ileri/geri hareket
        float verticalInput = Input.GetAxis("Vertical") ; // İleri hareket için değeri tersine çevirin

        // Yatay dönüşü yerel uzayda uygula
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);

        // İleri ve geri hareketi yerel uzayda uygula
        Vector3 forwardMovement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;
        transform.Translate(forwardMovement, Space.World);
    }
}



