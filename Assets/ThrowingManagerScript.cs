using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool locked = false;
    GameObject ball;

    public void Make()
    {
        
        if (!locked)
        {
            GameObject.Find("BallMaker").GetComponent<BallMakerBehaviour>().MakeBall(1);
            locked = true;
        }
    }
    public void Throw(float force)
    {
        
        ball= GameObject.Find("Throwable");
        float zdepth = ball.transform.position[2] + 1;
        ball.GetComponent<BallBehaviour>().Throw(Camera.main.ViewportToWorldPoint(new Vector3(0.5f,0.5f,zdepth*force)), 1);
        locked = false;
    }

    public float TotalDestroyDelay = 5;
    public float SingleDestroyDelay = 0.05f;
    public void Purge()
    {
        StartCoroutine("PurgeWorker");
    }

    private IEnumerator PurgeWorker()
    {
        int len = GameObject.FindGameObjectsWithTag("Simulated").Length;
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Simulated"))
        {
            StartCoroutine("ScaleDestroy", obj);
            yield return new WaitForSeconds(TotalDestroyDelay/ len);
        }
    }

    private IEnumerator ScaleDestroy(GameObject obj)
    {
        Vector3 orig = obj.transform.localScale;
        int steps = 100;
        for (int i = steps; i > 0; i--)
        {
            obj.transform.localScale = orig * i / steps;
            yield return new WaitForSeconds(SingleDestroyDelay / steps);
        }
        Destroy(obj);
    }
}
