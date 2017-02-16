using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

	public GameObject bullet;
	private GameObject cloneBullet;
	public float speed=10f;

	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetButtonDown ("Fire1")) {

			cloneBullet = Instantiate (bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;

			Rigidbody rigBullet = cloneBullet.GetComponent<Rigidbody>();

			rigBullet.AddForce (cloneBullet.transform.forward*speed, ForceMode.Impulse);
		
		}
	
	}


}
