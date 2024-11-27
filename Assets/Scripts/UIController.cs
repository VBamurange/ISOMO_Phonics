using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject infoPanel;
    public GameObject pageA;
    public GameObject welcomePanel;

    [Header("Timing Settings")]
    public float splashScreeenDelay = 3f;

    [Header("Audio Settings")]
    public AudioSource backgroundMusic; 
    public Slider volumeSlider;


    void Start()
    {
        infoPanel.SetActive(false);
        pageA.SetActive(false);
        welcomePanel.SetActive(true);
        StartCoroutine(SwitchPanel());

        if (volumeSlider != null && backgroundMusic != null)
        {
            volumeSlider.value = backgroundMusic.volume; 
            volumeSlider.onValueChanged.AddListener(SetVolume); 
        }
    }

    
    void Update()
    {
        
    }

    IEnumerator SwitchPanel()
    {
        yield return new WaitForSeconds(splashScreeenDelay);
        pageA.SetActive(true);
        welcomePanel.SetActive(false);
    }

    public void SetVolume(float volume)
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.volume = volume;
        }
    }
}
