using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour
{
    private bool bombFlag = false;

    private void Start()
    {
        StartCoroutine(delay());
    }

    public void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Player"^other.tag == "Enemy") && bombFlag == true)
        {
            other.attachedRigidbody.AddForce((other.transform.position-transform.position)*300);
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
