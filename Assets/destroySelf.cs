using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("checkOutOfRange", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void checkOutOfRange()
    {
        print("checking");
        if (transform.position.sqrMagnitude>2000)
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        GameObject.Find("gameController").GetComponent<reset>().checkReset();
    }
}
