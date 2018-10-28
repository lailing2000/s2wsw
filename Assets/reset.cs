using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public GameObject[] goToEnable;
    public GameObject[] goToDisabled;
    public void resetAll()
    {
        for(int i = 0; i < goToEnable.Length; i++)
        {
            goToEnable[i].SetActive(true);
        }
        for (int i = 0; i < goToDisabled.Length; i++)
        {
            goToDisabled[i].SetActive(false);
        }
    }
    
    public void checkReset()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("ball");
        if (gos.Length == 0)
            resetAll();
    }

}
