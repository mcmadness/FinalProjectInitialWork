using UnityEngine;
using System.Collections;

public class SmartAI : MonoBehaviour {


	public float SmartAISpeed;
	GameObject Player ;

	void Start(){

		Player = GameObject.FindGameObjectWithTag ("Player");


	}


	// Update is called once per frame
	void Update () {



		if (Vector3.Distance (transform.position, Player.transform.position) > .01f) {
			
			transform.position += Vector3.Normalize (Player.transform.position - transform.position) * Time.deltaTime * SmartAISpeed;
		



		}


	}


	void OnDrawGizmos () {
		Gizmos.DrawLine (transform.position, Player.transform.position);



	}
}
