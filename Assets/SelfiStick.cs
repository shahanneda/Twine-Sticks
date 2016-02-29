using UnityEngine;
using System.Collections;

public class SelfiStick : MonoBehaviour {
	private GameObject player;
	public float panSpeed = 10f;
	private Vector3 armRotation;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Upate is called once per frame
	void Update () {
		armRotation.z += Input.GetAxis("RightH") * panSpeed;
		armRotation.x += Input.GetAxis("RightV") * panSpeed;
		transform.position = player.transform.position;
		transform.rotation = Quaternion.Euler(armRotation);
	}
}
