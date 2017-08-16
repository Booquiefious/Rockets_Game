using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Explotion;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit something");

       if(other.gameObject.tag == "Ground")
        {
            Debug.Log("Hit Gound");
            Death();
        }
    }

    void Death()
    {
        Debug.Log("Hit Gound");

        Destroy(gameObject);

        Instantiate(Explotion, transform.position, transform.rotation);
    }
}
