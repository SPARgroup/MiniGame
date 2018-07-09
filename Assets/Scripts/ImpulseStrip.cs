using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseStrip : MonoBehaviour {

    public float ImpulseForceX = 10f;
    public float ImpulseForceY = 10f;
    public float ImpulseForceZ = 10f;
    public float maxDeviationAmount = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "VIP")
        {
            ImpulseForceX = Random.Range(-maxDeviationAmount, maxDeviationAmount);
            ImpulseForceZ = Random.Range(-maxDeviationAmount, maxDeviationAmount);
            Impulse(ImpulseForceX, ImpulseForceY, ImpulseForceZ, collision.gameObject);
        }
    }

    public void Impulse(float ForceX, float ForceY, float ForceZ, GameObject vip)
    {
        Rigidbody rb = vip.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(ForceX, ForceY, 0);

        if(rb != null)
        {
            Debug.Log("IMPULSE!");
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
