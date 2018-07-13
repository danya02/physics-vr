using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;


public class BallMakerUI : MonoBehaviour {

    [SerializeField] private SelectionSlider Slider;
    [SerializeField] private GameObject BallMaker;

    // Use this for initialization
    void Start () {
        Slider.OnBarFilled += HandleSelectionComplete;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void HandleSelectionComplete() {
        BallMaker.GetComponent<BallMakerBehaviour>().MakeBall(1);
    }
}
