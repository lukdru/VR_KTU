using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TestGames : MonoBehaviour
{
    public SteamVR_Input_Sources handType; // 1
    public SteamVR_Action_Boolean clickAction; // 2

    GameObject Player;
    GameObject Recycling;
    GameObject Basketball;
    GameObject Elektronika;
    GameObject MonaLiza;
    private int IsGrown = 1;

    private void Start()
    {
        Player = GameObject.Find("Player");
        Recycling = GameObject.Find("TusiavimasTP");
        Basketball = GameObject.Find("KrepsinisTP");
        Elektronika = GameObject.Find("ElektronikaTP");
        MonaLiza = GameObject.Find("MonaLizaTP");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetClick())
        {
            print("Clicked " + handType);
        }

        if (IsGrown == 1)
        {
            Player.transform.localScale = new Vector3(1, 1, 1);
        }
        if (IsGrown == 2)
        {
            Player.transform.localScale = new Vector3(20, 20, 20);
        }
        if (IsGrown == 3)
        {
            Player.transform.localScale = new Vector3(50, 50, 50);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGrown++;
            if(IsGrown== 4)
            {
                IsGrown = 1;
            }

        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Elektronika");
            Player.transform.position = Elektronika.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Krepsinio Zona");
            Player.transform.position = Basketball.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("Rusiavimo Zona");
            Player.transform.position = Recycling.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("MonaLiza");
            Player.transform.position = MonaLiza.transform.position;
        }
    }

    public bool GetClick() // 1
    {
        return clickAction.GetStateDown(handType);
    }
}
