using UnityEngine;
using System.Collections;

public class Destriur : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision colision){

		Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
		Destroy (gameObject);
		
	}
}
