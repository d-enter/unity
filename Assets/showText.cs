using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showText : MonoBehaviour {

    public GameObject canvas;
    public GameObject text;

    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            text.GetComponent<Text>().text = "高峰岳\n(標高2800m)\n　　　南アルプス";
            canvas.SetActive(true);
        }
    }

    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionExit(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }

}
