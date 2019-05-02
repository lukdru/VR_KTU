using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class MenuButton : MonoBehaviour
{
    private string levelLoad = "MainScene";

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        if (other.gameObject.tag =="MainCamera")
        {
            Debug.Log("Kita Scena");
            SteamVR_LoadLevel.Begin(levelLoad);
            //SceneManager.LoadScene(levelLoad);
        }
    }
}
