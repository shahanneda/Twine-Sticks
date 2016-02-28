using UnityEngine;
using System.Collections;

public class CamPan : MonoBehaviour {
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");

	}
	
	void LateUpdate () {
		transform.LookAt(player.transform);
//		FollowBall ();
	}


	void FollowBall ()
	{
//		transform.Rotate(new Vector3(Input.GetAxis("RightH"),Input.GetAxis("RightH"),0));
//		transform.position = new Vector3(player.transform.position.x + offset.x,player.transform.position.y + offset.y,player.transform.position.z + offset.z);
//		//ball.transform.position.z + offset.z;
	}
}
