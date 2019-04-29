using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour
{
    public bool inBack = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inBack = true;
            Debug.Log("Ranka uz nugaros !");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inBack = false;
            Debug.Log("Ranka nebe uz nugaros :/");
        }
    }
}
