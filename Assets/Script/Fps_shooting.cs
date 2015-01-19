using UnityEngine;
using System.Collections;

public class Fps_shooting : MonoBehaviour {

	public GameObject bullet_prefab;
	public GameObject explotion;
	// Use this for initialization
	float bulletImpulse = 40.0f;
	void Start () {
	
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name =="target")
		{
			Instantiate(explotion, col.transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
				Camera cam = Camera.main;		
			    GameObject thebullet = (GameObject)Instantiate (bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
				thebullet.rigidbody.AddForce(cam.transform.forward* bulletImpulse, ForceMode.Impulse);
				
				Destroy(thebullet,3.0f);
			}
			
		}

	}

