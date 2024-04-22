using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumenSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider MasterSlider;
    [SerializeField] private Slider MusicSlider;
    [SerializeField] private Slider SFXSlider;


    public void SetMasterVolumen()
    {
        float volumen = MasterSlider.value;
        audioMixer.SetFloat("Master", Mathf.Log10(volumen)*20);
    }
    public void SetMusicVolumen()
    {
        float volumen = MusicSlider.value;
        audioMixer.SetFloat("Music", Mathf.Log10(volumen) * 20);
    }
    public void SetSFXVolumen()
    {
        float volumen = SFXSlider.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(volumen) * 20);
    }
}
