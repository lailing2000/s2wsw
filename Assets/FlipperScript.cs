using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// referencing to Unity3D Pinball Tutorial Part II- The Flippers(https://www.youtube.com/watch?v=y7WgV8-yfcI)
public class FlipperScript : MonoBehaviour {
    public float resetPos = 0f;
    public float pressedPos = 45f;
    public float hitStrength = 100000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public KeyCode kc;
    // Use this for initialization
    void Start () {
        ignoreCollision();
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;
        if(kc==KeyCode.LeftArrow)
        {
            if (Input.GetKey(kc)|| Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Backslash))
            {
                spring.targetPosition = pressedPos;
            }
            else
            {
                spring.targetPosition = resetPos;
            }
        }
        else
        {
            if (Input.GetKey(kc) || Input.GetKey(KeyCode.Slash))
            {
                spring.targetPosition = pressedPos;
            }
            else
            {
                spring.targetPosition = resetPos;
            }
        }




        hinge.spring = spring;
        hinge.useLimits = true;
	}
    public Collider box;

    void ignoreCollision()
    {
        Physics.IgnoreCollision(box, GetComponent<Collider>());
    }
}
