using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class ValueChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Slider.OnBarFilled += Action;
    }
    [SerializeField] private SelectionSlider Slider;
    public enum Modes { MODE_ADD, MODE_SUBTRACT };
    public Modes MyMode;
    public GameObject ValueStore;

	// Update is called once per frame
	void Update () {
		
	}

    void Action() {
        if (MyMode==Modes.MODE_ADD)
            ValueStore.GetComponent<ValueStorer>().Add();
        else
            ValueStore.GetComponent<ValueStorer>().Subtract();
    }
}
