using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void Action<in T>(T Obj);
public class ReloadRetransaytor : MonoBehaviour
{
    private Action<bool> OnRestart;
    public void AddRestartListener(Action<bool> onRestart)
    {
        OnRestart += onRestart;
    }
    public void RemoveRestartListener(Action<bool> onRestart)
    {
        OnRestart -= onRestart;
    }
    public virtual void OnRestarting()
    {
        OnRestart?.Invoke(true);
    }
}
