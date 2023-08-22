using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void FormButton()
    {
        SceneManager.LoadScene("FormScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SettingSaveButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainScene");
    }




}
