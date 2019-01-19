using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_change : MonoBehaviour
{
    GameObject obj; // オブジェクトのインスタンス　トリガーIndex取得用
    GameObject timer_obj;
    random_pos scr; // オブジェクトのクラスを入れる
    instantiate_obj getter;

    public static CSVWrite out_file = new CSVWrite(); // ファイル書き出しクラス

    public bool isTrigger;
    public static string result = "";
  

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Sphere"); // オブジェクトの名前から検索して格納する
        timer_obj = GameObject.Find("init_obj");
        scr = obj.GetComponent<random_pos>(); // スクリプトを取得して格納する
        getter = timer_obj.GetComponent<instantiate_obj>();
        isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Random.Range(-5.0f,5.0f),Random.Range(-5.0f,5.0f),Random.Range(-5.0f,5.0f));

        int index = scr.index; // トリガーindexを取得

        switch(index) // 色を変えたときに場所もランダムで移動させてやらないと同じ場所に出るからすぐ見つかってしまう
        {
            case 0: // yellow > red
                this.gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1: // red > blue 
                this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2: // blue > yellow;
                this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }

        if (isTrigger)
        {
            float time = getter.time;        
            // ここでファイル書き出し
            out_file.fileSave(time.ToString());
            isTrigger = false;
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)) // トリガー離したとき
        {
            isTrigger = true;
        }
    }
}
