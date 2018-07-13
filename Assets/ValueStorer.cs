using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueStorer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float Value = 0;
    public float DeltaValue = 0.1f;
    public bool IsInteger = false;
	// Update is called once per frame
	void Update () {
        if (!IsInteger)
        {
            GetComponent<TextMesh>().text = Value.ToString();
        }
        else {
            GetComponent<TextMesh>().text = ((int)Value).ToString();
        }
	}

    public void Add() { Value += DeltaValue; }
    public void Subtract() { Value -= DeltaValue; }

}
