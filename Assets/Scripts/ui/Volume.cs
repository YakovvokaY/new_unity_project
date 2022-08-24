using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] Slider slider;
    private void Awake()
    {
        slider.onValueChanged.AddListener(value => AudioListener.volume = value);
    }
}
