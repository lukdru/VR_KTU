using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballCourt : MonoBehaviour
{
    public GameObject Ball;
    public GameObject SpawnPlace;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball" || other.gameObject.tag == "Ball1")
        {
            //Debug.Log("Paliko baudos aikstele!");
            Instantiate(Ball, SpawnPlace.transform.position, Quaternion.identity);
        }
    }
}
