

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Laser : MonoBehaviour {
    public CapsuleCollider col;
    public MeshRenderer mesh;

    public bool isBlinking = true;
    public float frequency;

    public Coroutine blinkingCoroutine;

	// Use this for initialization
	void Start () {
        col = gameObject.GetComponent<CapsuleCollider>();
        mesh = gameObject.GetComponent<MeshRenderer>();

        blinkingCoroutine = StartCoroutine(Blinking());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerator Blinking()
    {
        while (isBlinking)
        {
            col.enabled = !col.enabled;
            mesh.enabled = !mesh.enabled;
            yield return new WaitForSeconds(1 / frequency);
        }
        
        
   }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "VIP")
            Destroy(collision.gameObject);
        
    }
}
