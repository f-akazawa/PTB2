using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_move : MonoBehaviour
{
    Vector3 to_pos = new Vector3(0, 0, 0); // 移動先
	Vector3 from_pos = new Vector3(0,0,0); // 初期位置

    public float time = 3.0f; // 移動時間
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        from_pos.x = float.Parse(initDotDemo.in_file.csvDatas[0][0]);
		from_pos.y = float.Parse(initDotDemo.in_file.csvDatas[0][1]);
		from_pos.z = float.Parse(initDotDemo.in_file.csvDatas[0][2]);
		to_pos.x = float.Parse(initDotDemo.in_file.csvDatas[1][0]);
		to_pos.y = float.Parse(initDotDemo.in_file.csvDatas[1][1]);
		to_pos.z = float.Parse(initDotDemo.in_file.csvDatas[1][2]);
		
        this.gameObject.transform.position = from_pos;// 初期位置
        startTime = Time.timeSinceLevelLoad; // 開始時間を記録
    }

    // Update is called once per frame
    void Update()
    {
        var diff = Time.timeSinceLevelLoad - startTime;
        if(diff > time)
        {
            transform.position = to_pos;
        }
        
        var rate = diff / time;

        transform.position = Vector3.Lerp(from_pos,to_pos,rate);

        if (to_pos == this.gameObject.transform.position )//デモはX座標がおなじになったら戻して繰り返す
        {
            this.gameObject.transform.position = from_pos;
            startTime = Time.timeSinceLevelLoad; // 開始時間も初期化
        }
    }
}
