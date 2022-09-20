using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour
{
    private float nextSpavnTime;
    private int FPSW = 0;
    private int FPS = 0;
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        FPSW++;
        if (Time.time > nextSpavnTime)
        {
            nextSpavnTime = Time.time + 1;
            FPS = FPSW;
            FPSW = 0;
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(50, 10, 100, 30), $"FPS : {FPS.ToString()}");
    }
}
