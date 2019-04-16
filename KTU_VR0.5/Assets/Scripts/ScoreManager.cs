using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public Text field;

    void Start()
    {
        field = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        //Debug.Log("UpdatingScore");
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("SpaceDown");
            AddPoints(1);
        }
        field.text = " " + score;
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    private void Reset()
    {
        score = 0;
    }
}
