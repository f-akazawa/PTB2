	using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVRead : MonoBehaviour {
	public List<string[]> csvDatas = new List<string[]>();

	public void CsvRead (string inputName) {
		// load CSV
		var DataFolderPath = Application.persistentDataPath + "/"; // windows "C:/Users/akaz/AppData/LocalLow/hi_lab/UEC_VPS/" Oculus go "/storage/emulated/0/Android/data/jp.ac.uec.hi_lab/files"
		FileInfo fi = new FileInfo(DataFolderPath+inputName+".csv");
		StreamReader sr = new StreamReader(fi.OpenRead());
		var csvFile = sr.ReadToEnd();	

//		var csvFile = Resources.Load ("CSV/" + inputName) as TextAsset;
//	    var reader = new StringReader (csvFile.text);
		var reader = new StringReader(csvFile);
		while (reader.Peek () > -1) {
			// separate comma
			string line = reader.ReadLine ();
			// # is comment
			if (line[0] !='#'){
				csvDatas.Add (line.Split (','));
			}
		}
		reader.Close();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
