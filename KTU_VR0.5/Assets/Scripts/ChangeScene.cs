using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class ChangeScene : MonoBehaviour
{
    public string levelLoad = "MainScene";
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Escape");
            Application.Quit();
        }
        if (Input.GetKey("[+]"))
        {
            SteamVR_LoadLevel.Begin(levelLoad);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        if (other.gameObject.tag =="MainCamera")
        {
            Debug.Log("Kita Scena");
            SteamVR_LoadLevel.Begin(levelLoad);
            ///SceneManager.LoadScene(levelLoad);
        }
    }
}
