using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Throw(Vector3 to, float force)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().AddForce(-1*to * force, ForceMode.Impulse);
        gameObject.name = "Thrown";

    }
}
