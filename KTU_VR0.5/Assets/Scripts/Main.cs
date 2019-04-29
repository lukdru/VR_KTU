using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Main : MonoBehaviour
{
    public GameObject ControllerRight;
    public Camera MainCamera;

    public int Points;

    // Update is called once per frame
    void Update()
    {
        //Check();
        //Check2();
        //if(SteamVR_Input._default.
    }

    public void Check()
    {
        if (ControllerRight.transform.eulerAngles.z > 145 && ControllerRight.transform.eulerAngles.z < 155 && ControllerRight.transform.eulerAngles.x < 150)
            Debug.Log("Controller Inverted");
        else
            Debug.Log(ControllerRight.transform.eulerAngles.z);
    }

    public void Check2()
    {
        if (ControllerRight.transform.forward == MainCamera.transform.forward)
        {
            Debug.Log("Controller Inverted");
        }
    }
}
