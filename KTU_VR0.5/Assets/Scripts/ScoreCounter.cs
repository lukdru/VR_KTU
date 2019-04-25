using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int pointsToAdd = 1;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && GameObject.Find("Back").GetComponent<BackScript>().inBack == true)
        {
            //ScoreManager.AddPoints(pointsToAdd);
            Debug.Log("Taskas!");
            Destroy(gameObject);
        }
    }
}
