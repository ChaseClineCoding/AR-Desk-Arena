using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

	private Animator mAnimator;
	// Use this for initialization
	void Start () {
		mAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		bool walking = Input.GetKey ("up") || Input.GetKey("down") || Input.GetKey("right") || Input.GetKey("left");

		mAnimator.SetBool ("walking", walking);

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			mAnimator.SetTrigger ("attack");
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			mAnimator.SetTrigger ("attack2");
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			mAnimator.SetTrigger ("attack3");
		}
	}
}
