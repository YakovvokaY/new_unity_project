using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pspawn : MonoBehaviour
{
    [SerializeField] GameObject spawnObj1;
    [SerializeField] GameObject spawnObj2;
    [SerializeField] GameObject mineGost;
    [SerializeField] GameObject mineDestroyGost;
    //[SerializeField] Transform spawnPoint;
    private int spawnIndex;
    private void Start()
    {
        mineGost.SetActive(false);
        mineDestroyGost.SetActive(false);
        spawnIndex = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mineGost.SetActive(false);
            mineDestroyGost.SetActive(false);
            spawnIndex = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mineGost.SetActive(true);
            mineDestroyGost.SetActive(false);
            spawnIndex = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            mineGost.SetActive(false);
            mineDestroyGost.SetActive(true);
            spawnIndex = 2;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (spawnIndex==1)
            {
                Instantiate(spawnObj1, transform.position, transform.rotation);
            }
            else if (spawnIndex==2)
            {
                Instantiate(spawnObj2, transform.position , transform.rotation);
            }
        }
    }
}
