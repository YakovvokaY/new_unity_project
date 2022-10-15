using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace minimap
{
    public sealed class RadarObj : MonoBehaviour
    {
        [SerializeField] private Image _ico;
        private void OnDisable()
        {
            Radar.RaemoveRadarObject(gameObject);
        }
        private void OnEnable()
        {
            Radar.RegisterRadarObject(gameObject, _ico);
        }
    }
}