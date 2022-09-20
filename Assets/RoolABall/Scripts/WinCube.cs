using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCube : Cube
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Messege("WinCube", "Win");
            Destroy(gameObject);
        }
    }
}