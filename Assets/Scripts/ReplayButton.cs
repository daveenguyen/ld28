using UnityEngine;
using System.Collections;

public class ReplayButton : MonoBehaviour {
	
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			// Whatever you want it to do.
			Application.LoadLevel(0);
		}
	}

}
