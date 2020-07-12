using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopController : MonoBehaviour
{
    string[] strArray = { "Apple", "Orange", "Banana", "Grape", "Kiwi" };

    void Start()
    {
        Loop1();
        Loop2();
        Loop3();
        Loop4();
    }

    void Loop1()
    {
        Debug.Log("Loop1 ==========");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    void Loop2()
    {
        Debug.Log("Loop2 ==========");
        int[] intArray = { 5, 3, 7, 8, 9 };
        for (int i = 0; i < intArray.Length; i++)
        {
            int x = intArray[i] * 2;
            Debug.Log(x);
        }
    }

    void Loop3()
    {
        Debug.Log("Loop3 ==========");
        for (int i = 0; i < strArray.Length; i++)
        {
            Debug.Log(strArray[i]);
        }
    }

    void Loop4()
    {
        Debug.Log("Loop4 ==========");
        foreach (string s in strArray)
        {
            Debug.Log(s);
        }
    }
}
