using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hwTesting : MonoBehaviour
{
    private List<int> TestingList = new List<int> {1,2,3,2,2,4,5};
    private string testString = "string";
    private void Start()
    {
        Debug.Log(testString.Len());
        NOfEachS(TestingList);
    }
    private void NOfEachS (List<int> list)
    {
        List<int> AllS = new List<int>();
        List<int> NOfS = new List<int>();
        for (int i=0;i<list.Count;i++)
        {
            bool flag = true;
            for (int i2 = 0; i2 < i; i2++)
            {
                if (list[i] == list[i2])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                AllS.Add(list[i]);
            }
        }
        for (int i = 0; i < AllS.Count; i++)
        {
            NOfS.Add(0);
            for (int i2 = 0; i2 < list.Count; i2++)
            {
                if (AllS[i]==list[i2])
                {
                    NOfS[i] = NOfS[i] + 1;
                }
            }
            Debug.Log($"{AllS[i]} (всего: {NOfS[i]})");
        }
    }
}