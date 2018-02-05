using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	public Transform enemy;

	// Use this for initialization
	void Start () {

	}

	//	 Update is called once per frame
	void Update () {
		transform.LookAt (enemy);

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * .3f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * .3f;

		transform.Translate(x, 0, 0);
		transform.Translate(0, 0, z);
	}
}
