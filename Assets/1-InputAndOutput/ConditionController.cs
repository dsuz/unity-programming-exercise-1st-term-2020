using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionController : MonoBehaviour
{
    void Start()
    {
        int a = 10;

        Debug.Log("a の中身は " + a.ToString());

        if (a == 5)
        {
            Debug.Log("a は 5 である");
        }
        else if (a > 5)
        {
            Debug.Log("a は 5 より大きい");
        }
        else
        {
            Debug.Log("a は 5 ではなく、5 より大きくもない");
        }
    }

    void Update()
    {
        
    }
}
