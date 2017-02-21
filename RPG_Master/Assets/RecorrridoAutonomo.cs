using UnityEngine;
using System.Collections;

public class RecorrridoAutonomo : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent agente;
	public Transform destiny;

	// Use this for initialization
	void Start () {
	
		agente = GetComponent <UnityEngine.AI.NavMeshAgent>();
		agente.SetDestination (destiny.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
