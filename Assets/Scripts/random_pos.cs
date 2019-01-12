using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pos : MonoBehaviour
{
    GameObject obj; // タイマー取得のためカウントしているオブジェクトの格納用
    instantiate_obj script; // タイマーを動かしている初期化スクリプトの格納用
    
    public int index = 0;
    public float MinRange,MaxRange;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("init_obj"); // 初期化用に用意した空のゲームオブジェクトを検索して格納する
        script = obj.GetComponent<instantiate_obj>(); // 初期化ゲームオブジェクトのスクリプトを格納する
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Random.Range(MinRange,MaxRange),Random.Range(MinRange,MaxRange),Random.Range(MinRange,MaxRange));

        float time = script.time; // タイマーを取得

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) // トリガー押した判定はここだけにすること（色んな所でやると時間がずれるかも？ということ
        {
            // トリガー押された
            index+=1;
            if (index == 3)
            {
                index = 0;
            }
            
            switch(index)
            {
                case 0: // blue > yellow
                    this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                    Debug.Log("Time" + time);
                    break;
                case 1: // yellow > red
                    this.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    Debug.Log("Time" + time);
                    break;
                case 2: // red > blue
                    this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    Debug.Log("Time" + time);
                    break;
            }
            
        }
    }
}
