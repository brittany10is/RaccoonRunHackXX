using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public GameObject anim;
    public GameObject head;

    // Update is called once per frame
    private void LateUpdate()
    {
    //print(anim.transform.position);
        anim.transform.rotation = head.transform.rotation;
    }
}
