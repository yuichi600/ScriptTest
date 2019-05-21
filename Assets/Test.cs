using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	int mp = 53;
	string message;

	public string useMp(){
		if(mp>0){
			//MPの減算
			mp -= 5;
			//0以下になった場合は0で表示
			if(mp<0) mp=0;
			//メッセージの作成
			message = "魔法攻撃をした。残りMPは"+mp+"ポイントに減りました。";
		}else{
			//メッセージの作成
			message = "MPが足りないため魔法が使えない。";
		}
		return message;
	}
	
	
}
public class Test : MonoBehaviour {

	// Use this for initialization	
	void Start(){
		//処理を実行する回数を作成
		int[] array_test = new int[15];
		//返信の方を宣言
		string message;
		//クラスの読み込み
		Boss test = new Boss();

		foreach(int v in array_test){
			//処理を実行
			message = test.useMp();
			//取得メッセージを表示
			Debug.Log(message);
		}
		/* 
		【課題】
		int[] array_test = new int[5];

		array_test[0] = 10;
		array_test[1] = 20;
		array_test[2] = 40;
		array_test[3] = 50;
		array_test[4] = 100;

		//For分（昇順）
		for(int v=0;v<5;v++){
			Debug.Log("Count = "+array_test[v]);
		}
		//For分（降順）
		for(int v=4;v>=0;v--){
			Debug.Log("Count = "+array_test[v]);
		}
		//Foreach
		foreach(int v in array_test){
			Debug.Log("Couont = "+v);
		}
		*/
	}
	// Update is called once per frame
	void Update () {
		
	}
}
