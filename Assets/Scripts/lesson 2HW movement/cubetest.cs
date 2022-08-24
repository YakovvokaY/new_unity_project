using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubetest : MonoBehaviour
{
    [SerializeField] Slider Slider;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Slider.value = Slider.value + 1;
            Destroy(gameObject);
        }
    }
}