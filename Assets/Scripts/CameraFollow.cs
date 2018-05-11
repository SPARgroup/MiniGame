using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject vip;

    public float height;
    public float unChapeDist;
    public float smoothness = 0.9f;

    // Use this for initialization
    void Start () {
        vip = GameObject.FindGameObjectWithTag("VIP");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {

        Vector3 targetTransform = new Vector3(vip.transform.position.x, vip.transform.position.y + height, vip.transform.position.z + unChapeDist);

        transform.position = Vector3.Lerp(transform.position, targetTransform,smoothness);
    
    }
}
