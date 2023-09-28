using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeControl : MonoBehaviour
{
    public Slider masterSlider;
    public Slider soundSlider;
    public Slider musicSlider;

    public TMP_InputField masterValue;
    public TMP_InputField soundValue;
    public TMP_InputField musicValue;

    public void AdjustVolume () {
        AudioListener.volume = masterSlider.value;
        masterValue.text = masterSlider.value.ToString("0.00");
    }


    public void AdjustSlider()
    {
        masterSlider.value = float.Parse(masterValue.text);
    }
}
