using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TestGames : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Vector2 JoystickVector;

    GameObject Teleporting;
    GameObject Player;
    GameObject Recycling;
    GameObject Basketball;
    GameObject Elektronika;
    GameObject MonaLiza;

    private int IsGrown = 1;
    private Vector3 TopGrow = new Vector3 (50, 50, 50);
    private Vector3 BottomGrow = new Vector3(1, 1, 1);
    private Vector3 CurrentScale;
    private Vector3 StartScale;
    private bool SpacePressed = false;

    private void Start()
    {
        
        Player = GameObject.Find("Player");
        Teleporting = GameObject.Find("Teleporting");
        Recycling = GameObject.Find("RusiavimasTP");
        Basketball = GameObject.Find("KrepsinisTP");
        Elektronika = GameObject.Find("ElektronikaTP");
        MonaLiza = GameObject.Find("MonaLizaTP");
        CurrentScale = Player.transform.localScale;
        StartScale = Player.transform.localScale;
        Player.transform.position = Player.transform.position + new Vector3(0, 1.3f, 0);
    }

    void Update()
    {
        Scaling();
        Places();
        ScalingWithSpace();
    }

    void Places()
    {
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

        if (Input.GetKey("escape"))
        {
            Debug.Log("Escape");
            Application.Quit();
        }

        if (Input.GetKeyDown("[-]"))
        {
            Debug.Log("Elektronika");
            CurrentScale = StartScale;
        }

        if (Input.GetKeyDown("[+]"))
        {
            Debug.Log("Elektronika");
            CurrentScale = new Vector3(50f, 50f, 50f);
        }
    }

    void Scaling()
    {
        Vector2 JSValue = JoystickVector.GetAxis(SteamVR_Input_Sources.Any);

        if (JSValue.y > 0.3 && TopGrow.x >= CurrentScale.x)
        {
            //Debug.Log("VIRSUJ");
            CurrentScale = CurrentScale + new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (JSValue.y < -0.3 && BottomGrow.x <= CurrentScale.x)
        {
            //Debug.Log("APACIOJ");
            CurrentScale = CurrentScale - new Vector3(0.1f, 0.1f, 0.1f);
            Debug.Log(CurrentScale);
        }
        //Debug.Log(CurrentScale);
        Player.transform.localScale = CurrentScale;
        Teleporting.transform.localScale = CurrentScale;
        //Debug.Log(Player.transform.localScale);
    }

    void ScalingWithSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGrown++;
            if (IsGrown == 4)
            {
                IsGrown = 1;
            }
            if (IsGrown == 1)
            {
                CurrentScale = new Vector3(1, 1, 1);
            }
            if (IsGrown == 2)
            {
                CurrentScale = new Vector3(20, 20, 20);
            }
            if (IsGrown == 3)
            {
                CurrentScale = new Vector3(50, 50, 50);
            }
        }
    }
}
