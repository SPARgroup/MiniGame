using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class VIPTracker : MonoBehaviour {

    public TiltController tiltController;
    public GameObject vip;

	// Use this for initialization
	void Start () {

        tiltController = GameObject.FindGameObjectWithTag("Player").GetComponent<TiltController>();

        vip = GameObject.FindGameObjectWithTag("VIP");
        this.transform.position = vip.transform.position;
        this.transform.rotation = vip.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {

        //this.transform.rotation = Quaternion.Euler(tiltController.gameObject.transform.rotation.x, vip.transform.rotation.y, transform.rotation.z);
        if(vip != null)
        {
            this.transform.position = vip.transform.position;

            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(CrossPlatformInputManager.GetAxis("Vertical") * tiltController.amount, 0, 0), tiltController.sensitivity);

            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -CrossPlatformInputManager.GetAxis("Horizontal") * tiltController.amount), tiltController.sensitivity);
        }
      
    }
}
