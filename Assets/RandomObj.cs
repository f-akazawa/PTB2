using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObj : MonoBehaviour {

	public GameObject targetGameObject;
	public float MinRange,MaxRange;
	public int numberObj;
	float x,y,z;
	// Use this for initialization
	void Start () {
		for (int i = 0; i <= numberObj; i++) {
      		Instantiate(targetGameObject, new Vector3(Random.Range(MinRange, MaxRange),
            	Random.Range(MinRange, MaxRange),
            	Random.Range(MinRange, MaxRange)),
				Quaternion.identity);
    	}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
