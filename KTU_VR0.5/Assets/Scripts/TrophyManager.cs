using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class TrophyManager : MonoBehaviour
{
    public static int score;
    private string levelLoad = "MainScene";
    public Text scorefield;
    public GameObject scoreObject;

    void Start()
    {
        score = 0;
        scoreObject = GameObject.Find("HandScore");
        scorefield = scoreObject.GetComponent<Text>();

        Debug.Log(scorefield.text + "TESTAS JEI 0");
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
            //SteamVR_LoadLevel.Begin(levelLoad);
            SceneManager.LoadScene(levelLoad);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

}
