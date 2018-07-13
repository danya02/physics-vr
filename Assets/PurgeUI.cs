using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;



public class PurgeUI : MonoBehaviour {

    [SerializeField] private SelectionSlider Slider;
    [SerializeField] private GameObject ThrowingManager;

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
        ThrowingManager.GetComponent<ThrowingManagerScript>().Purge();
        GameObject.Find("Make Ball").GetComponent<SelectionSlider>().enabled = true;
        GameObject.Find("Make Ball").GetComponent<SelectionSlider>().m_GazeOver = false;
        GameObject.Find("Make Ball").GetComponent<SelectionSlider>().HandleUp();
        GameObject.Find("Make Wall").GetComponent<SelectionSlider>().enabled = true;
        GameObject.Find("Make Wall").GetComponent<SelectionSlider>().m_GazeOver = false;
        GameObject.Find("Make Wall").GetComponent<SelectionSlider>().HandleUp();
    }
}
