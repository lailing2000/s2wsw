using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucebouceEmi : MonoBehaviour {
    public Transform start;
    public Transform end;
    public AudioClip ac;

    Vector3 dir;
	// Use this for initialization
	void Start () {
        dir = end.transform.position - start.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerExit(Collider other)
    {
        GameObject go = other.gameObject;

        Vector3 vel = go.GetComponent<Rigidbody>().velocity.normalized;

        GameObject.Find("gameController").GetComponent<state>().AddScore(300);
        go.GetComponent<Rigidbody>().AddForce(vel * 500 + dir*500);
        GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
    }
    
}
