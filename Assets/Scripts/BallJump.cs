using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BallJump : MonoBehaviour {

    public float jumpForce = 60f;

    //Force applied in the direction of the tilt of the floor to make the ball more controllable
    public float additionalForceAmount = 40f;

   // public GameObject vip;

    public Rigidbody rb;
    public Collider coll;
    public Transform vip_Parent;

    public bool isGrounded = false;
    public string vip_tracker_tag = "VIPTracker";

    public TiltController player;
    public VIPTracker vip_Tracker;

	// Use this for initialization
	void Start () {
        //vip = GameObject.FindGameObjectWithTag("VIP");
        rb = this.GetComponent<Rigidbody>();
        coll = this.GetComponent<Collider>();
        vip_Parent = GameObject.FindGameObjectWithTag("VIP Parent").transform;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<TiltController>();
        vip_Tracker = GameObject.FindGameObjectWithTag(vip_tracker_tag).GetComponent<VIPTracker>();
        
	}
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(vip_Tracker.transform.right * CrossPlatformInputManager.GetAxis("Horizontal") * additionalForceAmount 
                    + vip_Tracker.transform.forward * CrossPlatformInputManager.GetAxis("Vertical") * additionalForceAmount, ForceMode.Acceleration);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isGrounded = true;
        }
            
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isGrounded = false;
        }
            
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
