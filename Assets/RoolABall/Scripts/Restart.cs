using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    Transform StTransform;
    ReloadRetransaytor ReloadRetransaytor = new ReloadRetransaytor();
    private void Start()
    {
        StTransform.position = transform.position;
        StTransform.rotation = transform.rotation;
        Subscribe();
    }
    public void Subscribe()
    {
        ReloadRetransaytor.AddRestartListener(OnRestarting);
    }
    public void OnRestarting(bool f)
    {
        if (f)
        {
            transform.position = StTransform.position;
            transform.rotation = StTransform.rotation;
        }
    }
}