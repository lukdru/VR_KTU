using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrophyManager : MonoBehaviour
{
    public static int score;
    public Text scorefield;

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
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

}
