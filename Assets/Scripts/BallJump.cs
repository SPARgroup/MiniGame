using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour {

    public float jumpForce = 60f;
    public GameObject vipTracker;

    //Force applied in the direction of the tilt of the floor to make the ball more controllable
    public float additionalForceAmount = 40f;

   // public GameObject vip;

    public Rigidbody rb;
    public Collider coll;
    public Transform vip_Parent;

    public bool isGrounded = false;

    public TiltController player;

	// Use this for initialization
	void Start () {
        //vip = GameObject.FindGameObjectWithTag("VIP");
        rb = this.GetComponent<Rigidbody>();
        coll = this.GetComponent<Collider>();
        vip_Parent = GameObject.FindGameObjectWithTag("VIP Parent").transform;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<TiltController>();

        
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    public void Jump()
    {
        if (isGrounded)
        {
            Vector3 forceVector = new Vector3(0, jumpForce, 0);
            rb.AddForce(forceVector, ForceMode.Impulse);
            
        }     
    }
}
