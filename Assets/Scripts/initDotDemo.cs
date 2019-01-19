using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initDotDemo : MonoBehaviour
{
    public string CSVFile = "target"; // CSV file name デモは決め打ち
   
	public static CSVRead in_file = new CSVRead();
    // Start is called before the first frame update
    void Start()
    {
    	var CreateFolderPath = Application.persistentDataPath + "/"; // for oculus go 内部共有ストレージ直下にディレクトリ作成
		if (System.IO.Directory.Exists(CreateFolderPath)){
		//	Debug.Log("フォルダある"+CreateFolderPath);
		}else{
		//	Debug.Log("フォルダないので作る");
			System.IO.Directory.CreateDirectory(CreateFolderPath);
		}

        // read csv
		in_file.CsvRead(CSVFile); // CSVRead.csのcsvDatas[]にデータが入る
	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
