using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class instantiate_obj : MonoBehaviour
{
    public GameObject targetGameObject;
    public float MinRange,MaxRange;
    public int numberObj;
    float x,y,z;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= numberObj; i++) {
      		Instantiate(targetGameObject, new Vector3(Random.Range(MinRange, MaxRange),
            	Random.Range(MinRange, MaxRange),
            	Random.Range(MinRange, MaxRange)),
				Quaternion.identity);
        }
        time = 0;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;// フレームでカウント

        if (OVRInput.Get(OVRInput.RawButton.Back)) // バックボタンでendingシーンへ遷移、そこでメディアスキャンしておく
        {
            SceneManager.LoadScene("ending", LoadSceneMode.Single);
        }
    }
}
