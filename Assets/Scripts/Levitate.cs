using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour {

    public float strength = 1f ;
    public float speed = 1.5f;
    public Vector3 transformCurrent;
    // Use this for initialization
    void Start () {
        transformCurrent = (transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transformCurrent.x ,
            transformCurrent.y + Mathf.Sin(Time.time * speed)*strength,
            transformCurrent.z);  
	}
}
