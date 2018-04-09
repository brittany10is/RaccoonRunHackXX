using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour {

    public float XSpeed;
    public float YSpeed;
    public float ZSpeed;

	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(XSpeed, YSpeed, ZSpeed);
	}
}
