using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour {

	public GameManager gm;
	void OnTriggerEnter(){
		gm.EndGame();
	}
}
