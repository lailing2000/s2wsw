using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatexController : MonoBehaviour {
    public GameObject[] triggerer = new GameObject[3];
    public GameObject[] light = new GameObject[3];
    public AudioClip ac;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void closeLight(int index)
    {
        if(light[index].activeSelf)
            GameObject.Find("gameController").GetComponent<state>().AddScore(100);

        light[index].SetActive(false);
        checkPoint();

    }


    void checkPoint()
    {
        bool alldisactive = true;
        foreach(GameObject l in light)
        {
            if (l.activeSelf)
            {
                alldisactive = false;
            }
        }
        if (alldisactive)
        {

            GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
            GameObject.Find("gameController").GetComponent<state>().AddScore(5000);
            StartCoroutine(delayReset());
        }
    }

    IEnumerator delayReset()
    {
        yield return new WaitForSeconds(1f);
        for(int i = 0; i < light.Length; i++)
        {
            light[i].SetActive(true);
        }
    }
}
