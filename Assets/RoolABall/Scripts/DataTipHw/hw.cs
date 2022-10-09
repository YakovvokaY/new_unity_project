using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class hw
{
    private static int n = 0;
    public static int Len (this string str)
    {
        foreach (char c in str)
        {
            n++;
        }
        return n;
    }
    public static T AddTo<T>(this T self, ICollection<T> coll)
    {
        coll.Add(self);
        return self;
    }
}