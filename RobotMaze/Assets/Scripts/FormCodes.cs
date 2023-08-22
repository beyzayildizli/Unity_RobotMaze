using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using TMPro;

public class FormCodes : MonoBehaviour
{
    public GameObject formPanel;
    public GameObject finalPanel;
    public Toggle toggleWoman;
    public Toggle toggleMan;
    public TMP_Text textMeshProNesnesi;
    private string feadBack;
    private string username;
    private int choosenNum;
    public TMP_InputField nameInputField;

    void Start()
    {
        formPanel.SetActive(true);
        finalPanel.SetActive(false);
        toggleMan.isOn = false;
        toggleWoman.isOn = false;
        username = string.Empty;
        choosenNum = 0;
    }

    

    public void ToggleWoman()
    {
        toggleMan.image.color = Color.white;
        toggleWoman.image.color = Color.white;
        if (toggleWoman.isOn)
        {
            toggleMan.isOn = false;
        }
    }

    public void ToggleMan()
    {
        toggleMan.image.color = Color.white;
        toggleWoman.image.color = Color.white;
        if (toggleMan.isOn)
        {
            toggleWoman.isOn = false;
        }
    }

    public void DropdownValue(int selectedOptionIndex)
    {
        if (selectedOptionIndex == 0)
        {
            choosenNum = 0;
        }
        else if (selectedOptionIndex == 1)
        {
            choosenNum = 1;
        }
        else if (selectedOptionIndex == 2)
        {
            choosenNum = 2;
        }
    }

    private void FeedBack(int num)
    {
        if (num == 0)
        {
            feadBack = "Thank you " + username + ". We are glad you like it! We will keep improving!";
        }
        else if (num == 1)
        {
            feadBack = "Thank you " + username + ". We will keep working to make it better.";
        }
        else if (num == 2)
        {
            feadBack = username + ", thank you for your feedback. We will keep working to make it better.";
        }
    }


    public void UserName()
    {
        username = nameInputField.text;
        nameInputField.image.color = Color.white;
    }

    public void SendButton()
    {
        if(!string.IsNullOrEmpty(nameInputField.text))
        {
            if(toggleMan.isOn || toggleWoman.isOn)
            {
                formPanel.SetActive(false);
                finalPanel.SetActive(true);
                FeedBack(choosenNum);
                textMeshProNesnesi.text = feadBack;
            }
            else
            {
                toggleMan.image.color = Color.red; 
                toggleWoman.image.color = Color.red;
            }


        }
        else
        {
            nameInputField.image.color = Color.red; 
        }


    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
