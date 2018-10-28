using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class cylinderAddForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit(Collision collision)
    {
        GameObject go = collision.collider.gameObject;
        
        Vector3 vel = go.GetComponent<Rigidbody>().velocity.normalized;
        
        go.GetComponent<Rigidbody>().AddForce(vel * 300);

        GameObject.Find("gameController").GetComponent<state>().AddScore(500);
    }
}
