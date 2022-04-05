using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public Slider mainSlider;
    public AudioMixer mainMixer;
    private float value;

    private void Start()
    {
        mainMixer.GetFloat("MainValume", out value);
        mainSlider.value = value;
    }
    public void SetVolume()
    {
        

        mainMixer.SetFloat("MainValume", mainSlider.value);
    }
}
