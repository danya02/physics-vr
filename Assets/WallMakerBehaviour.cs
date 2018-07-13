using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMakerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float singlewidth = wwidth / cwidth;
        float singleheight = wheight / cheight;
        singlescale = new Vector3(singlewidth, singleheight, vdepth);

        cwidth = (int)GameObject.Find("Cwidth").GetComponentInChildren<ValueStorer>().Value;
        cheight = (int)GameObject.Find("Cwidth").GetComponentInChildren<ValueStorer>().Value;
        wwidth = GameObject.Find("Wwidth").GetComponentInChildren<ValueStorer>().Value;
        wheight = GameObject.Find("Wheight").GetComponentInChildren<ValueStorer>().Value;
        vdepth = GameObject.Find("Wdepth").GetComponentInChildren<ValueStorer>().Value;

    }

    public Vector3 singlescale;
    public GameObject cubeBasis;

    public int cwidth = 5;
    public int cheight = 5;
    public float wwidth = 5;
    public float wheight = 5;
    public float vdepth = 1;
    public float TotalMakeDelay = 5;
    public float SingleMakeDelay = 0.5f;
    public void MakeWall()
    {
        StartCoroutine("MakeWallWorker");
        
    }

    private class ObjectVector { public GameObject gameobject; public Vector3 vector;  public ObjectVector(GameObject o, Vector3 v) { gameobject = o; vector = v; } }
    private IEnumerator MakeWallWorker() {
        float singlewidth = wwidth / cwidth;
        float singleheight = wheight / cheight;
        for (int j = 0; j < cheight; j++)
        {
            for (int i = 0; i < cwidth; i++)
            {
                GameObject cube = Instantiate(cubeBasis);
                cube.transform.position = new Vector3((singlewidth * (i + 0.5f)) - wwidth / 2, singleheight * (j + 0.5f), 0);
                cube.transform.localScale = new Vector3(0,0,0);
                ObjectVector ov = new ObjectVector(cube, new Vector3(singlewidth, singleheight, vdepth));

                StartCoroutine("ZoomCube", ov);
                cube.tag = "Simulated";
                yield return new WaitForSeconds(TotalMakeDelay / (cwidth*cheight));

            }
        }
    }

    private IEnumerator ZoomCube(ObjectVector ov)
    {
        int steps = 100;
        for (int i=0; i<steps; i++)
        {
            ov.gameobject.transform.localScale = ov.vector * i/steps;
            yield return new WaitForSeconds(SingleMakeDelay / steps);
        }
    }
}
