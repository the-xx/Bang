using UnityEngine;
using System.Collections;

public class Bullet_boom : MonoBehaviour {


	// Use this for initialization
	public GameObject explotion;
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




	}

}


/*void OnCollisionEnter(Collision collision){

		//Destroy(gameObject);
			if(collision.gameObject.tag == "dumb"){
				collision.gameObject.tag = "untaged";
				Instantiate(explotion, collision.transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
	}*/

