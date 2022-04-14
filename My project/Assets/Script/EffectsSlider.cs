using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class EffectsSlider : MonoBehaviour
{
    public Slider effectsSlider;
    public AudioMixer mainMixer;
    private float value;

    private void Start()
    {
        mainMixer.GetFloat("EffectsValume", out value);
        effectsSlider.value = value;
    }
    public void SetVolume()
    {
        mainMixer.SetFloat("EffectsValume", effectsSlider.value);
    }
}