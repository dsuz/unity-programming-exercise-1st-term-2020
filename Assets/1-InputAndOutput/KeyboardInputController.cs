using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputController : MonoBehaviour
{
    void Update()
    {
        // 押されたタイミングで検出する
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Qが今押された");
        }

        // 離されたタイミングで検出する
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Wが今離された");
        }

        // 押しっぱなしを検出する
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Eが押されている");
        }
    }
}
