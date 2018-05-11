using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        this.transform.rotation = Quaternion.Euler(tiltController.gameObject.transform.rotation.x, vip.transform.rotation.y, transform.rotation.z);
        this.transform.position = vip.transform.position;
	}
}
