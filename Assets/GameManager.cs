using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class GameManager : MonoBehaviour {
	[HideInInspector]
	public bool recording = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {			

		if (CrossPlatformInputManager.GetButton ("Replay")) {
			
			recording = false;
		}else{
			
			recording = true;
		}
	}
	void Update(){
		print(CrossPlatformInputManager.GetAxis("RightH"));
		print(CrossPlatformInputManager.GetAxis("RightV"));

	}
}
