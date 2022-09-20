using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool flag = false;
    private bool enter = false;
    void Start()
    {

    }

    void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.E))
        {
            flag = !flag;
        }
        if (flag == true && transform.rotation.y*130 < 90)
        {
            transform.Rotate(new Vector3(0,1,0)*Time.deltaTime * 30);
            Debug.Log(transform.rotation.y);
        }
        if (flag == false && transform.rotation.y * 130 > 0)
        {
            Debug.Log(transform.rotation.y);
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 30);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }
}