//using UnityEngine;
//using System.Collections;
//
//public class Replay : MonoBehaviour {
//	private const int buffSize = 50;
//	private MyKeyFrame[] keyFrames = new MyKeyFrame[buffSize];
//	// Use this for initialization
//	private Rigidbody m_rigidbody;
//	private GameManager gameManager;
//	void Start () {
//		m_rigidbody = GetComponent<Rigidbody>();
//		gameManager = FindObjectOfType<GameManager>();
//	}
//
//	// Update is called once per frame
//	void Update () {
//		if(gameManager.recording){
//			Record ();
//
//		}else	{
//			Play();	
//		}
//
//	}
//	void Play(){
//		m_rigidbody.isKinematic = true;
//		int frame = Time.frameCount % buffSize;
//		transform.position = keyFrames[frame].positon;
//		transform.rotation = keyFrames[frame].Rot;
//	}
//	void Record ()
//	{
//		int frame = Time.frameCount % buffSize;
//		float time = Time.time;
//		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
//		print (frame);
//		print(Time.frameCount % buffSize);
//	}
//}
///// <summary>
///// A Struct For Storing Position And Rotational Data
///// </summary>
//public struct MyKeyFrame{
//	public float time;
//	public Vector3 positon;
//	public Quaternion Rot;
//	public MyKeyFrame(float nowTime,Vector3 pos,Quaternion rot){
//		time = nowTime;
//		positon = pos;
//		Rot = rot;
//	}
//
//}
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class Replay : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrames = new MyKeyFrame [bufferFrames];
	private Rigidbody rigidBody;
	private GameManager manager;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		manager = GameObject.FindObjectOfType<GameManager> ();
	}

	// Update is called once per frame
	void Update () {
		if (manager.recording) {
			Record ();
		} else if(!manager.recording) {
			PlayBack ();
		}

	}

	void PlayBack () {
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyFrames [frame].position;
		transform.rotation = keyFrames [frame].rotation;
	}

	void Record () {
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A structure for storing time, rotation and position.
/// </summary>
public struct MyKeyFrame {
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame (float aTime, Vector3 aPosition, Quaternion aRotation) {
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;
	}
}