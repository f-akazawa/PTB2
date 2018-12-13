using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {

	// Use this for initialization
	// オブジェクト生成時に初速度を与えて等速直線運動させる
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Rotate(new Vector3(Random.Range(0, 180),
                                 Random.Range(0, 180),
                                 Random.Range(0, 180)
                                ) * Time.deltaTime);
	}
}
