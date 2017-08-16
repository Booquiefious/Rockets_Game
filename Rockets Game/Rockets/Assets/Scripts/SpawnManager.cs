using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;

    public GameObject Rocket;

    private bool RocketIsSpawned = false;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Jump") && RocketIsSpawned == false)
        {
            Instantiate(Rocket, Spawn2.transform.position, Spawn2.transform.rotation);
            RocketIsSpawned = true;
        }

    }

}


