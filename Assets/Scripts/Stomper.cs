using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Stomper : MonoBehaviour
{
    #region //variables
    public float fallDistance = 10f;
    public bool isBallUnderMe = false;

    public GameObject vip;
    public GameObject cam;

    public Coroutine coroutine;
    #endregion 

    // Use this for initialization
    void Start()
    {
        vip = GameObject.FindGameObjectWithTag("VIP");
        cam = GameObject.FindGameObjectWithTag("Camera");
    }

    private void OnEnable()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnStomperEffect()
    {
        if (isBallUnderMe)
        {
            CameraShaker.Instance.ShakeOnce(3.5f, 3f, 0.1f, 1.5f);
            Destroy(vip);
            Debug.Log("Pata tha phatega xD");
        }

        
        
    }

}

