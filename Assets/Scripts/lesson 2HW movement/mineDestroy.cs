using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineDestroy : MonoBehaviour
{
    private bool bombFlag = false;
    void Start()
    {
        StartCoroutine(delay());
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Player" ^ other.tag == "Enemy") && bombFlag == true)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    private IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        bombFlag = true;
        StopCoroutine(delay());
    }
}
