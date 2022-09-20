using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDRotate : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RotateTo('W');
        }
        if (Input.GetKey(KeyCode.S))
        {
            RotateTo('S');
        }
        if (Input.GetKey(KeyCode.A))
        {
            RotateTo('A');
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotateTo('D');
        }
        else
        {

        }
    }
    private void RotateTo (char button)
    {
        switch (button)
        {
            case 'W':
                transform.Rotate(new Vector3 (1,0,0) * Time.deltaTime * 30);
                break;
            case 'S':
                transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * 30);
                break;
            case 'A':
                transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 30);
                break;
            case 'D':
                transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 30);
                break;
        }
    }
}