using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVWrite : MonoBehaviour {

    public string outputName = "result_vsj2019"; // デモはファイル名決め打ち

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fileSave(string result){
		StreamWriter sw;
		FileInfo fi;
		var DataFolderPath = Application.persistentDataPath + "/"; // windows "C:/Users/akaz/AppData/LocalLow/hi_lab/UEC_VPS/" Oculus go "/storage/emulated/0/Android/data/jp.ac.uec.hi_lab/files"
		sw = new StreamWriter(DataFolderPath+outputName+".csv",true);
		// 書き出すテキストを作成
		string txt = result+',';
		sw.WriteLine(txt); // 書き出し改行込み
		sw.Flush(); // バッファ書き込み
		sw.Close(); // ストリーム閉じる
		// Debug.Log("write to "+DataFolderPath+outputName+".csv");
		// Debug.Log("write data = "+txt);
		// Flag update
	}
	
}

