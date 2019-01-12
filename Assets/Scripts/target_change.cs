using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_change : MonoBehaviour
{
    GameObject dots; // random dotsのカラー情報（index)
    random_pos script; // 沢山出る方(random dots)にアタッチしたスクリプトを入れる変数

    // Start is called before the first frame update
    void Start()
    {
        dots = GameObject.Find("Sphere"); // オブジェクトの名前から検索して格納する
        script = dots.GetComponent<random_pos>(); // random dotsの方にあるスクリプトを取得して格納する
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Random.Range(-5.0f,5.0f),Random.Range(-5.0f,5.0f),Random.Range(-5.0f,5.0f));

        int index = script.index; // random dots のindexを格納

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
    }
}
