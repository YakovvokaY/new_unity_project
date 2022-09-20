using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static void Messege(string Name,string Func)
    {
        switch (Func)
        {
            case "Destroy":
                Debug.Log($"Cube {Name}: {Func}");
                break;
            case "Win":
                Debug.Log($"Cube {Name}: {Func} )))");
                break;
        }
    }
}
