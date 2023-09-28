using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeControl : MonoBehaviour
{

    public Slider[] volumeSliders;
    public TMP_InputField[] volumeValues;

    /* public Slider masterSlider;
    public Slider soundSlider;
    public Slider musicSlider;

    public TMP_InputField masterValue;
    public TMP_InputField soundValue;
    public TMP_InputField musicValue; */

    public void AdjustVolume(int volumeType)
    {
        if (volumeType < 0 || volumeType >= volumeSliders.Length || volumeType >= volumeValues.Length)
        {
            Debug.LogError("Invalid volume type."+ volumeType);
            return;
        }
        //volumeSliders[]

        AudioListener.volume = volumeSliders[volumeType].value;
        volumeValues[volumeType].text = volumeSliders[volumeType].value.ToString("0.00");

/*         switch (volumeType)
        {
        case 0:
            AudioListener.volume = masterSlider.value;
            masterValue.text = masterSlider.value.ToString("0.00");
            break;
        case 1:
            AudioListener.volume = soundSlider.value;
            soundValue.text = soundSlider.value.ToString("0.00");
            break;
        case 2:
            AudioListener.volume = musicSlider.value;
            musicValue.text = musicSlider.value.ToString("0.00");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        } */
    }

    public void AdjustSlider(int volumeType)
    {
        volumeSliders[volumeType].value = float.Parse(volumeValues[volumeType].text);
    }    
}
