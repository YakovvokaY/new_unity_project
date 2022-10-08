using UnityEngine;

public class CommandGiving : MonoBehaviour
{
    private ReloadObj[] reloadObjects;

    private void Start()
    {
        reloadObjects = FindObjectsOfType<ReloadObj>();
    }
    public void Reload()
    {
        foreach (ReloadObj reloadObj in reloadObjects)
        {
            reloadObj.Reload();
        }
    }
}