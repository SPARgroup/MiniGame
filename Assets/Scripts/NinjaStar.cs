using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStar : MonoBehaviour {


    public float rotationSpeed;
    


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.RotateAroundLocal(Vector3.forward, Time.deltaTime * rotationSpeed);
	}
}
