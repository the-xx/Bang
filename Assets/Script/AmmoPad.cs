using UnityEngine;
using System.Collections;

public class AmmoPad : MonoBehaviour {
	public GameObject bullet_prefab;

	void OnTriggerStay(Collider other){
		bullet_prefab.renderer.material.color = other.renderer.material.color;

	}
}
