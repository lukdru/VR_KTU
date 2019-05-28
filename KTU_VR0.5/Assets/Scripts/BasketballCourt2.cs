using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballCourt2 : MonoBehaviour
{

    //public GameObject Ball;
    //public GameObject SpawnPlace;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Collidino su ribomis");
            //Ball.GetComponent<Rigidbody>().isKinematic = true;
            //Ball.GetComponent<Rigidbody>().isKinematic = false;
            //Ball.transform.position = SpawnPlace.transform.position;
            //Destroy(other.gameObject);
            //Instantiate(Ball, SpawnPlace.transform.position, Quaternion.identity);
        }
    }




}
