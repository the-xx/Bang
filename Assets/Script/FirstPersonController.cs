using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;
[RequireComponent(typeof(CharacterController))]

public class FirstPersonController : MonoBehaviour {
	public float rotateSpeed;
	public float forwardSpeed;
	public float mouseSensitivity = 5.0f;
	public float movementSpeed = 5.0f;

	//float verticalRotation = 0;
	public float upDownRange = 60.0f;
	private CharacterController playerController;

	//public GameObject myo = null;
	// Use this for initialization
	void Start () {
		playerController = GetComponent<CharacterController> ();
	//	Screen.lockCursor = true; //get rid of the mouse in the begning
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		//movement
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		float speed = forwardSpeed * Input.GetAxis("Vertical");
		playerController.Move (speed * forward *Time.deltaTime);

		//rotation

		/*float rotLeftRight = myo.transform.forward.x * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		verticalRotation -= myo.transform.forward.y * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);*/

	}
}
