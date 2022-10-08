using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownScale : Cube
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Messege("DownCube", "Destroy");
            ScaleDown(other, 0.8f);
        }
    }
    private void ScaleDown(Collider other, float i)
    {
        other.gameObject.transform.localScale = other.gameObject.transform.localScale * i;
        gameObject.SetActive(false);
    }
}
