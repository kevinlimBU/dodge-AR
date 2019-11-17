using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

	

	void OnTriggerEnter(Collider coll){
		//if (coll.CompareTag("P1")){
			SceneManager.LoadScene ("SampleScene");
		//}
	}

}
