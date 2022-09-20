using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class temperature : MonoBehaviour
{
    public float T_min;
    public float T_max;
    private float tempirature;
    bool enter;
    [SerializeField] PostProcessVolume PPV;
    private ColorGrading ColorGrading;
    private void Start()
    {
        PPV.profile.TryGetSettings(out ColorGrading);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
            StartCoroutine(gradientPlus());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
            StartCoroutine(gradientMinus());
        }
    }
    private IEnumerator gradientPlus()
    {
        for (float i = T_min; i <= T_max; i++)
        {
            ColorGrading.temperature.value = i;
            if (enter==true)
            {
                StopCoroutine(gradientPlus());
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        StopCoroutine(gradientPlus());
    }
    private IEnumerator gradientMinus()
    {
        for (float i = T_max; i >= T_max; i--)
        {
            ColorGrading.temperature.value = i;
            if (enter == false)
            {
                StopCoroutine(gradientMinus());
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        StopCoroutine(gradientMinus());
    }
}
