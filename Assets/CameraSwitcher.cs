using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcam1;

    [SerializeField]
    private CinemachineVirtualCamera vcam2;

    private bool camera1Bool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchPriority()
    {
        if(camera1Bool)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
        camera1Bool = !camera1Bool;
    }
}
