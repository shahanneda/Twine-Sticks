using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class GameManager : MonoBehaviour {
	public bool recording = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {			
		print(CrossPlatformInputManager.GetAxis("Replay"));

		if (CrossPlatformInputManager.GetButton ("Replay")) {
			recording = false;
		}else{
			recording = true;
		}
	}
}
