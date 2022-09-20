using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SMPHB : MonoBehaviour
{

    [SerializeField] Slider Slider;
    private void Start()
    {
        SetMaxPoints();
    }
    private void SetMaxPoints()
    {
        Slider.maxValue = 10;
        Slider.value = 0;
    }
}
