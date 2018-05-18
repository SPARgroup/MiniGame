using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomper : MonoBehaviour
{
    #region //variables
    public float fallDistance = 10f;

    public bool isBallUnderMe = false;

    GameObject vip;

    public Coroutine coroutine;
    #endregion 

    // Use this for initialization
    void Start()
    {
        vip = GameObject.FindGameObjectWithTag("VIP");
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
            Destroy(vip);
            Debug.Log("Pata tha phatega xD");
        }
        
    }

}

