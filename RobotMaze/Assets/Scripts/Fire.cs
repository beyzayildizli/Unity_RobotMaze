using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fire : MonoBehaviour
{
    RaycastHit hit;
    int point = 100;
    private bool isOpen;
    private bool isFinish;
    private GameObject door;
    public GameObject panel;
    public TMP_Text textMeshProNesnesi;

    void Start()
    {
        isOpen = false;
        isFinish = false;
        door = GameObject.Find("Hinge");
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit; 

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider.gameObject.CompareTag("WrongWay"))
                {
                    Destroy(hit.collider.gameObject);
                    point -= 10; 
                }
                else if (hit.collider.gameObject.CompareTag("TrueWay"))
                {
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.gameObject.CompareTag("FinalWall"))
                {
                    OpenDoor(door);
                    Debug.Log("Total Point:: " + point);
                    panel.SetActive(true);
                    textMeshProNesnesi.text = "Total Point: " + point;
                }
            }
        }
    }

    private void OpenDoor(GameObject door)
    {
        if (isOpen)
        {
            door.transform.Rotate(new Vector3(0, -90, 0));
            isOpen = false;
        }
        else
        {
            if (!isFinish)
            {
                Debug.Log("POINT: " + point);
                isFinish = true;
            }
            door.transform.Rotate(new Vector3(0, 90, 0));
            isOpen = true;
        }
    }

}
