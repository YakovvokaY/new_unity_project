using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpScale : Cube
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Messege("UpscaleCube", "Destroy");
            Scale(other, 1.2f);
        }
    }
    private void Scale (Collider other,float i)
    {
        other.gameObject.transform.localScale = other.gameObject.transform.localScale * i;
        Destroy(gameObject);
    }
}
