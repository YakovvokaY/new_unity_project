using UnityEngine;

public class WinCube : Cube
{
    [SerializeField] private GameObject WinScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Messege("WinCube", "Win");
            gameObject.SetActive(false);
            WinScreen.SetActive(true);
        }
    }
}