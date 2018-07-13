using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;


public class WallMakerUI : MonoBehaviour
{

    [SerializeField] private SelectionSlider Slider;
    [SerializeField] private GameObject WallMaker;

    // Use this for initialization
    void Start()
    {
        Slider.OnBarFilled += HandleSelectionComplete;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void HandleSelectionComplete()
    {
        WallMaker.GetComponent<WallMakerBehaviour>().MakeWall();
    }
}
