using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Codes : MonoBehaviour
{
    public GameObject panel;
    public GameObject settingsPanel;
    public GameObject controlsPanel1;
    public GameObject controlsPanel2;
    public GameObject panelBack;

    public AudioSource muzikNesnesi;
    public AudioSource muzikNesnesi2;

    private AudioSource gameMusic;
    public Toggle toggleNesnesi;
    public Slider sliderNesnesi;

    private float sesDuzeyi;

    void Start()
    {
        panel.SetActive(false);
        settingsPanel.SetActive(false);
        controlsPanel1.SetActive(false);
        controlsPanel2.SetActive(false);
        panelBack.SetActive(false);
        sesDuzeyi = sliderNesnesi.value;
        gameMusic = muzikNesnesi;
        gameMusic.Play();

    }

    public void ToggleDegeriDegisti()
    {
        if (toggleNesnesi.isOn)
        {
            gameMusic.volume = sliderNesnesi.value;
        }
        else
        {
            gameMusic.volume = 0.0f;
            sliderNesnesi.value = 0.0f;
        }
    }

    public void SliderDegeriDegisti()
    {
        if(sliderNesnesi.value != 00)
        {
            toggleNesnesi.isOn = true;
        }
        sesDuzeyi = sliderNesnesi.value;
        SesDuzeyiniAyarla(sesDuzeyi);
    }

    public void SesDuzeyiniAyarla(float yeniDuzey)
    {
        gameMusic.volume = yeniDuzey;
    }

    public void DropdownValue(int selectedOptionIndex)
    {

        if (selectedOptionIndex == 0)
        {
            gameMusic = muzikNesnesi;
            muzikNesnesi2.Stop();
            gameMusic.Play();
            gameMusic.volume = sliderNesnesi.value;
        }
        else if (selectedOptionIndex == 1)
        {
            gameMusic = muzikNesnesi2;
            muzikNesnesi.Stop();
            gameMusic.Play();
            gameMusic.volume = sliderNesnesi.value;
        }
    }



    

    public void MenuButton()
    {
        settingsPanel.SetActive(false);
        controlsPanel1.SetActive(false);
        controlsPanel2.SetActive(false);
        panel.SetActive(true);
        panelBack.SetActive(true);
    }

    public void ExitMenuButton()
    {
        settingsPanel.SetActive(false);
        controlsPanel1.SetActive(false);
        controlsPanel2.SetActive(false);
        panel.SetActive(false);
        panelBack.SetActive(false);
    }

    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
        panel.SetActive(false);
        controlsPanel1.SetActive(false);
        panelBack.SetActive(true);
    }

    public void SaveSettingsButton()
    {
        settingsPanel.SetActive(false);
        controlsPanel1.SetActive(false);
        controlsPanel2.SetActive(false);
        panel.SetActive(true);

    }

    

    public void ControlsButton()
    {
        controlsPanel1.SetActive(true);
        controlsPanel2.SetActive(false);
        panel.SetActive(false);
        panelBack.SetActive(true);
    }

    public void Controls2Button()
    {
        controlsPanel2.SetActive(true);
        controlsPanel1.SetActive(false);
        panelBack.SetActive(true);
    }

    public void SaveControlsButton()
    {
        controlsPanel2.SetActive(false);
        panel.SetActive(true);
    }


}
