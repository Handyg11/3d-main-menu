using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCamController : MonoBehaviour {

	public Transform currentMount;
	public float speedFactor = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, currentMount.position, speedFactor);
		transform.rotation = Quaternion.Slerp(transform.rotation, currentMount.rotation, speedFactor);
	}

	public void setMount(Transform newMount){
		currentMount = newMount;
	}

	public void quitProgram(){
		 Application.Quit();
	}
}
