using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGames : MonoBehaviour
{
    GameObject Player;
    GameObject Recycling;
    GameObject Basketball;

    private void Start()
    {
        Player = GameObject.Find("Player");
        Recycling = GameObject.Find("Bottle2");
        Basketball = GameObject.Find("Bottle2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Rusiavimo Zona");
            Player.transform.position = Recycling.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Krepsinio Zona");
            Player.transform.position = Recycling.transform.position;
        }
    }
}
