using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider[] volumeSliders;
    public TMP_InputField[] volumeValues;

    //https://forum.unity.com/threads/solved-find-all-audiomixergroups.320913/
    public AudioMixerGroup[] AllMixerGroups {
        get{
            return mixer.FindMatchingGroups(string.Empty);
        ;}
    }

    public void AdjustVolume(int volumeType)
    {
        
        Debug.Log(AllMixerGroups[volumeType]);
        Debug.Log(Mathf.Log10(Mathf.Clamp(volumeSliders[volumeType].value, 0.0001f, 1f)) * (80) / 4f + 0);
        
        if (volumeType < 0 || volumeType >= volumeSliders.Length || volumeType >= volumeValues.Length)
        {
            Debug.LogError("Invalid volume type."+ volumeType);
            return;
        }

        //https://stackoverflow.com/questions/46529147/how-to-set-a-mixers-volume-to-a-sliders-volume-in-unity
        //sets the volume of the chosen audio group, converts (0-1) value to linear db value
        mixer.SetFloat(AllMixerGroups[volumeType].ToString(), Mathf.Log10(Mathf.Clamp(volumeSliders[volumeType].value, 0.0001f, 1f)) * (80) / 4f + 0);
        
        volumeValues[volumeType].text = volumeSliders[volumeType].value.ToString("0.00");
    }

    public void AdjustSlider(int volumeType)
    {
        volumeSliders[volumeType].value = float.Parse(volumeValues[volumeType].text);
    }    
}
