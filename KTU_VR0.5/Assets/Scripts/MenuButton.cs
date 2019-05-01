using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    private string levelLoad = "MainScene";

    void onTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        if (other.gameObject.tag =="Player")
        {
            Debug.Log("Kita Scena");
            SceneManager.LoadScene(levelLoad);
        }
    }
}
