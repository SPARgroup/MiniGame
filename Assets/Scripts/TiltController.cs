using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TiltController : MonoBehaviour {

    public float amount = 15f;
    public float sensitivity = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(CrossPlatformInputManager.GetAxis("Vertical") * amount, 0, 0), sensitivity);

        gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0,-CrossPlatformInputManager.GetAxis("Horizontal") * amount), sensitivity);
    }
}
