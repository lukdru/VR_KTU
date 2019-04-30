using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGames : MonoBehaviour
{
    GameObject Player;
    GameObject Recycling;
    GameObject Basketball;
    GameObject Elektronika;

    private void Start()
    {
        Player = GameObject.Find("Player");
        Recycling = GameObject.Find("Bottle2");
        Basketball = GameObject.Find("Bottle2");
        Elektronika = GameObject.Find("Elektronika");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Elektronika");
            Player.transform.position = Elektronika.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Krepsinio Zona");
            Player.transform.position = Recycling.transform.position;
        }
    }
}
