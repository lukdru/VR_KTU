using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderBottom : MonoBehaviour
{
    public int score;
    public int result = 5;
    public Text scorefield;
    public Text resultfield;
    public GameObject trophy;
    public GameObject Spawn;

    private void Start()
    {
        //trophy.SetActive(false);
        resultfield.text = "" + result.ToString();
    }

    void Update()
    {
        scorefield.text = "" + score.ToString();
        if (score == result)
        {
            //trophy.SetActive(true);
            Instantiate(trophy, Spawn.transform.position, Quaternion.identity);
            score = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Paimtas daiktas" + other.name);
        if (other.gameObject.tag == "Ball" && (GameObject.Find("Counting").GetComponent<ColliderTop>().OnTop == true))
        {
            score++;
            //Debug.Log("Taskas!");
        }
    }


}
