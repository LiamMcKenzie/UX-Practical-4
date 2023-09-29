using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SensitivityControl : MonoBehaviour
{
    public Slider sensitivitySlider;
    public TMP_InputField sensitivityValue;

    public void AdjustValue()
    {  
        sensitivityValue.text = sensitivitySlider.value.ToString("0.0");
    }

    public void AdjustSlider()
    {
        sensitivitySlider.value = float.Parse(sensitivityValue.text);
    }    
}
