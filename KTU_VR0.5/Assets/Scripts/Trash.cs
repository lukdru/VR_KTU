using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Trash : MonoBehaviour
{
    public GameObject trophy;
    int goal = 9;

    void Start()
    {
        trophy.SetActive(false);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (gameObject.tag == "Paper" && other.gameObject.tag == "Paper")
        {
            InBin(other);
        }
        if (gameObject.tag == "Plastic" && other.gameObject.tag == "Plastic")
        {
            InBin(other);
        }
        if (gameObject.tag == "Glass" && other.gameObject.tag == "Glass")
        {
            InBin(other);
            Debug.Log("Stiklas ikrito");
        }
        Debug.Log("Rezultatas = " + goal);
    }

    void InBin(Collider other)
    {
        other.gameObject.GetComponent<Interactable>().highlightOnHover = false;
        other.gameObject.GetComponent<Interactable>().handFollowTransform = false;
        other.gameObject.GetComponent<Throwable>().attachmentFlags = Hand.AttachmentFlags.TurnOnKinematic;
        goal--;
        Debug.Log("!!!");
        if (goal == 0)
        {
            trophy.SetActive(true);
            Debug.Log("Gavai priza");
        }
    }
}
