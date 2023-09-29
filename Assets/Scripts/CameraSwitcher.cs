using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    List<CinemachineVirtualCamera> vcams = new List<CinemachineVirtualCamera>();
    //[SerializeField]
    //private CinemachineVirtualCamera vcam1;

    //[SerializeField]
   // private CinemachineVirtualCamera vcam2;

    //private bool camera1Bool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchPriority(int cameraIndex)
    {
        for(int i = 0; i < vcams.Count; i++)
        {
            vcams[i].Priority = 0;
        }
        vcams[cameraIndex].Priority = 1;
    }
}
