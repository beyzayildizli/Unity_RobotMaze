using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    private bool isFirstCameraActive = true;

    void Start()
    {
        // İlk kamera etkin, diğeri devre dışı başlasın
        firstCamera.enabled = true;
        secondCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Uygulama içinde Space tuşuna basıldığında kamera geçişi yap
            isFirstCameraActive = !isFirstCameraActive;
            firstCamera.enabled = isFirstCameraActive;
            secondCamera.enabled = !isFirstCameraActive;
        }
    }
}
