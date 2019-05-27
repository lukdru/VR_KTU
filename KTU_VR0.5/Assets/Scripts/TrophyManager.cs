using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class TrophyManager : MonoBehaviour
{
    public static int score;
    public Text scorefield;
    private string levelLoad = "MainScene";

    void Start()
    {
        //scorefield = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        //Debug.Log("UpdatingScore");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("SpaceDown");
            AddPoints(1);
        }
        scorefield.text = "" + score.ToString();

        if (score == 15)
        {
            score = 0;
            SteamVR_LoadLevel.Begin(levelLoad);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

}
