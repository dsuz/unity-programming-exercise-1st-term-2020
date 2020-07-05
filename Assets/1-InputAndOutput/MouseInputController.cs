using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("左クリックを離した");
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("右クリック");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("中（ホイール）クリック");
        }

        // 左ボタンを押している間はマウスの位置を Console に出力する
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition.ToString());
        }
    }
}
