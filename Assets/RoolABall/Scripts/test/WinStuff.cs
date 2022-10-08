using UnityEngine;
public class WinStuff : MonoBehaviour , IReload
{
    public void Reload()
    {
        Debug.Log("!");
        gameObject.SetActive(false);
    }
}