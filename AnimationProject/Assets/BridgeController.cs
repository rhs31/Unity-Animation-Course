using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeController : MonoBehaviour {

	public Animator anim;

	void OnTriggerEnter(Collider obj)
	{
		anim.SetBool("open",true);
	}

	void OnTriggerExit(Collider obj)
	{
		anim.SetBool("open",false);
	}

}
