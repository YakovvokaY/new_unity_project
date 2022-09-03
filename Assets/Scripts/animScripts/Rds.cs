using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rds : MonoBehaviour
{
    private Rigidbody[] rb = new Rigidbody[6];
    private Rigidbody GObjRb;
    private void Start()
    {
        StartCoroutine(death());
    }
    void a()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            if (child.TryGetComponent(out Rigidbody f) == false)
            {
                rb[i] = child.GetComponentInChildren<Rigidbody>();
                i++;
            }
            else
            {
                rb[i] = child.GetComponent<Rigidbody>();
                i++;
            }
            
        }
        foreach (Rigidbody RbChild in rb)
        {
            RbChild.isKinematic = false;
            RbChild.useGravity = true;
        }
    }
    IEnumerator death()
    {
        yield return new WaitForSeconds(1);
        GObjRb = gameObject.GetComponent<Rigidbody>();
        GObjRb.isKinematic = false;
        GObjRb.useGravity = true;
        a();
        yield return new WaitForSeconds(1);
        StopCoroutine(death());
    }

}
