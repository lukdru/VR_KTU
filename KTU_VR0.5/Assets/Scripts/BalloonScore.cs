using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonScore : MonoBehaviour
{

    public int Goal = 20;
    private int Score = 0;
    public GameObject Trophy;
    public GameObject ArcherSpawn;
    public Text scorefield;
    public Text resultfield;


    private void Start()
    {
        resultfield.text = "" + Goal.ToString();
    }

    void Update()
    {
        scorefield.text = "" + Score.ToString();
        if (Score == Goal)
        {
            Instantiate(Trophy, ArcherSpawn.transform.position, Quaternion.identity);
            Score = 0;
        }
    }

    public void AddPoints(int points)
    {
        Score= Score + points;
    }
}
