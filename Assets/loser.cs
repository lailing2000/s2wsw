using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loser : MonoBehaviour {
    public AudioClip ac;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {

        GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
    }
}
