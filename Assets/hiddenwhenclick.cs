using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hiddenwhenclick : MonoBehaviour {
    public Text blinkword;
	// Use this for initialization
	void Start () {

        InvokeRepeating("blink", 1f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            gameObject.SetActive(false);
        }
	}
    void blink()
    {
        blinkword.gameObject.SetActive(!blinkword.gameObject.activeSelf);


    }
}
