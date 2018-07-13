using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireframeRotivator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GL.wireframe = true;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0.5f, 0);
        transform.localScale = GameObject.Find("WallMaker").GetComponent<WallMakerBehaviour>().singlescale;
	}
}
