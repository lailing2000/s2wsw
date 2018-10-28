using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperCol : MonoBehaviour {

    public AudioClip ac;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {

        GameObject.Find("gameController").GetComponent<state>().AddScore(200);
        GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
    }
}
