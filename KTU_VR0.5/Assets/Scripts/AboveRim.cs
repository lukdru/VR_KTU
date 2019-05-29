using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboveRim : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball1" || other.gameObject.tag == "Ball")
        {
            Debug.Log("Virs Lanko");
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Rigidbody>().isKinematic = false;
            //Ball.transform.position = SpawnPlace.transform.position;
            //Destroy(other.gameObject);
            //Instantiate(Ball, SpawnPlace.transform.position, Quaternion.identity);
        }
    }
}
