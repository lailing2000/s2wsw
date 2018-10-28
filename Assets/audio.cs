using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour {
    public AudioClip ac;
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        
    }

    // Update is called once per frame
    void Update () {

    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
    }
}
