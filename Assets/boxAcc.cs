using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class boxAcc : MonoBehaviour {
    public float forceSize = 300;
    public AudioClip ac;
    public bool playMusic;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(transform.right * forceSize);
        if(playMusic)
            GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
    }

    
    

}
