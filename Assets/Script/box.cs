using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {

	public GameObject bullet_prefab;
	public GameObject cube;
	
	void OnTriggerStay(Collider other){
		if (other.gameObject.name == "Cylinder") {
			renderer.material.SetColor( "bullet_prefab", cube.renderer.material.color);
			//bullet_prefab.renderer.material.color = cube.renderer.material.color;
				}
	}
}
