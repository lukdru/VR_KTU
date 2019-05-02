using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    public int pointsToAdd = 1;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Paimtas daiktas" + other.name);
        if (other.gameObject.tag == "Player" && ( GameObject.Find("LeftHand").GetComponent<BackScript>().inBack == true || GameObject.Find("RightHand").GetComponent<BackScript>().inBack == true))
        {
            Destroy(gameObject);
            TrophyManager.AddPoints(pointsToAdd);
            //Debug.Log("Taskas!");
        }
    }
}
