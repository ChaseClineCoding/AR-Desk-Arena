using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimController : MonoBehaviour {

	public Transform target;
	private Animator enemyAnim;

	// Use this for initialization
	void Start () {
		enemyAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target) 
		{
			for (int i = 0; i < 10; i++) 
			{
				enemyAnim.SetTrigger ("attack");
			}
		}
	}
}
