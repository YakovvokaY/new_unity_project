using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuActive : MonoBehaviour
{
    [SerializeField] GameObject SAHB;
    [SerializeField] GameObject SAMenu;
    private bool flag = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            flag = !flag;
            if (flag==false)
            {
                Cursor.lockState = CursorLockMode.Locked;
                SAHB.SetActive(true);
                SAMenu.SetActive(flag);
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                SAHB.SetActive(false);
                SAMenu.SetActive(flag);
            }
        }
    }
}
