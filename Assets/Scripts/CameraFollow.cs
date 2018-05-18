using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject vip_follower;

    public float height;
    public float unChapeDist;
    public float smoothness = 0.9f;

    // Use this for initialization
    void Start () {
        vip_follower = GameObject.FindGameObjectWithTag("VIP_Follower");
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void LateUpdate()
    {

        

    }

    private void FixedUpdate()
    {
        Vector3 targetTransform = new Vector3(vip_follower.transform.position.x, vip_follower.transform.position.y + height, vip_follower.transform.position.z + unChapeDist);

        transform.position = Vector3.Lerp(transform.position, targetTransform, Time.deltaTime * smoothness);
    }
}
