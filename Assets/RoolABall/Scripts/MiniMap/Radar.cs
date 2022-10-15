using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace minimap
{
    public class Radar : MonoBehaviour
    {
        [SerializeField] private Transform _playerPos;
        private float _mapScale = 2;
        public static List<RadarObject> RadarObjects = new List<RadarObject>();
        public static void RegisterRadarObject(GameObject o, Image i)
        {
            Image image = Instantiate(i);
            RadarObjects.Add(new RadarObject { Owner = o, Icon = image });
        }
        public static void RaemoveRadarObject(GameObject o)
        {
            List<RadarObject> newList = new List<RadarObject>();
            foreach (RadarObject t in RadarObjects)
            {
                if (t.Owner == o)
                {
                    Destroy(t.Icon);
                    continue;
                }
                newList.Add(t);
            }
            RadarObjects.RemoveRange(0, RadarObjects.Count);
            RadarObjects.AddRange(newList);
        }
        private void DrawRadarDots()
        {
            foreach (RadarObject radarObject in RadarObjects)
            {
                Vector3 radarPos = (radarObject.Owner.transform.position - _playerPos.position);

                radarPos.x = radarPos.x * 2;
                radarPos.z = radarPos.z * 2;

                radarObject.Icon.transform.SetParent(transform);
                radarObject.Icon.transform.position = new Vector3(radarPos.x, radarPos.z, 0) + transform.position;


            }
        }
        void Update()
        {
            if (Time.frameCount % 2 == 0)
            {
                DrawRadarDots();
            }
        }
    }
    public sealed class RadarObject
    {
        public Image Icon;
        public GameObject Owner;
    }
}