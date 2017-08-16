using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Rocket;

    private bool RocketIsSpawned = true;

    public Vector3 RocketOffset;       

    void Start()
    {
        RocketOffset = transform.position - Rocket.transform.position;

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && RocketIsSpawned == false)
        {
            RocketIsAlive();
        }
    }

    
    void LateUpdate()
    {
        if (RocketIsSpawned == true)
        {
            transform.position = Rocket.transform.position + RocketOffset;
        }
    }

    void RocketIsAlive()
    {
        RocketIsSpawned = true;

        RocketOffset = transform.position - Rocket.transform.position;

    }
}
