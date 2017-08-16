using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float Speed;

    public float TurnSpeed;

	void Update ()
    {

        transform.Translate(Vector3.up * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(TurnSpeed, Time.deltaTime, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-TurnSpeed, Time.deltaTime, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-TurnSpeed, Time.deltaTime, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(TurnSpeed, Time.deltaTime, 0, Space.World);
        }


    }
}
