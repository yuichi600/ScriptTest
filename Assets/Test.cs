using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization	
	void Start(){

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

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
