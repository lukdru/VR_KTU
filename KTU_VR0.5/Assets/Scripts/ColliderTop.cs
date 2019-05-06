using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTop : MonoBehaviour
{
    public bool OnTop = false;
    bool BasketballCoroutineStart = false;

    private void Update()
    {
        if (BasketballCoroutineStart == true)
        {
            StartCoroutine(BasketballCoroutine());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            OnTop = true;
            BasketballCoroutineStart = true;
            //Debug.Log("Kamuolys virsuj!");
        }
    }

    IEnumerator BasketballCoroutine()
    {
        yield return new WaitForSeconds(1);
        OnTop = false;
        BasketballCoroutineStart = false;
        //Debug.Log("Nebesiskaito");
    }
}
