using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour {
    public int totalTypesAvailable = 3;
    public int totalNumberOfPlatforms;

    public GameObject previousPlatform;
    public GameObject currentPlatform;

    public int rotationOffset = 0; //pending

    public GameObject[] typesOfPlatforms;
    

	// Use this for initialization
	void Start () {
        previousPlatform = Instantiate(typesOfPlatforms[0]); //spawn the first prefab to initiate
        rotationOffset = 0;
        
        //remove "-1" if you want to have "totalNumberOfPlatforms" number of platforms to spawn except of start platform
        for (int i = 0; i < totalNumberOfPlatforms - 1; i++) //
        {
            PlaceRandomPlatform();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlaceRandomPlatform( )
    {
        if(previousPlatform.tag == "90DegreeTurn")
        {
            rotationOffset -= 90;
        }

        Quaternion spawnRotation = Quaternion.Euler(0, rotationOffset, 0);

        currentPlatform = typesOfPlatforms[Random.Range(0, totalTypesAvailable  )]; //choose random platform

        GameObject spawnedPlatform = Instantiate(currentPlatform); //instantiate at origin
        
        Transform endPt = previousPlatform.transform.Find("EndPoint"); //find end point of previous platform
        Transform startPt = currentPlatform.transform.Find("StartPoint"); //find start point of current platform (At origin)

        Vector3 displaceVector = endPt.position - startPt.position; //subtract to find the net difference

        spawnedPlatform.transform.position = spawnedPlatform.transform.position + displaceVector; //move by that difference
        spawnedPlatform.transform.rotation = spawnRotation;
        previousPlatform = spawnedPlatform; //set previous platform as the spawned platform
    }
}
