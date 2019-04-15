using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject ControllerRight;
    public Camera

    // Update is called once per frame
    void Update()
    {
        if (ControllerRight.transform.eulerAngles.z > 145 && ControllerRight.transform.eulerAngles.z < 155 && ControllerRight.transform.eulerAngles.x < 150)
            Debug.Log("Controller Inverted");
        else
            Debug.Log(ControllerRight.transform.eulerAngles.z);
    }
}
