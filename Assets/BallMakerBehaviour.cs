using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMakerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject ballBasic;
    public GameObject ballPoke;
	
    public enum BallType { BASIC, POKE};

    // Update is called once per frame
	void Update () {
		
	}


    public void MakeBall(float diameter, float mass, BallType bt)
    {
        GameObject myball;
        switch (bt) { case BallType.BASIC: myball = Instantiate(ballBasic); break;
                case BallType.POKE: myball = Instantiate(ballPoke); break;
            default: myball = Instantiate(ballBasic); break; }
    

        myball.name = "Throwable";
        myball.tag = "Simulated";
        myball.transform.position = transform.position;
        myball.transform.localScale = new Vector3(diameter, diameter, diameter);
       // myball.GetComponent<Rigidbody>().mass = mass;
        myball.GetComponent<Rigidbody>().useGravity = false;

    }

    public void MakeBall( float diameter) { MakeBall(diameter, 1, BallType.POKE); }
}
