using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class elasticity : MonoBehaviour {
    bool firstHit = true;
    public GameObject block;
    public AudioClip ac;
    // Use this for initialization
    void Start () {
        block.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (firstHit)
        {
            GetComponent<AudioSource>().PlayOneShot(ac, 0.7F);
            firstHit = false;
            StartCoroutine(waitfor5sec(collision.collider.gameObject));
        }
    }
    IEnumerator waitfor5sec(GameObject go)
    {
        go.GetComponent<Rigidbody>().velocity = Vector3.zero;
        yield return new WaitForSeconds(0.5f);
        go.GetComponent<Rigidbody>().AddForce(transform.up * 5000);
        transform.localScale = transform.localScale + new Vector3(0, 0.5f, 0);

        GameObject.Find("gameController").GetComponent<state>().AddScore(500);
        yield return new WaitForSeconds(0.5f);
        block.SetActive(true);
        yield return null;
    }
}

