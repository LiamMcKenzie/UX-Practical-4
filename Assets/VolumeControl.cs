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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaster()
    {

    }
}
