using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left: MonoBehaviour
{
    public GameObject anim;
    public GameObject armLeft;

    // Update is called once per frame
    private void LateUpdate()
    {
        float xvalue = armLeft.transform.eulerAngles.x;
        float yalue = armLeft.transform.eulerAngles.y;
        float zalue = armLeft.transform.eulerAngles.z;
        yalue =  yalue;

        print(xvalue + " " + yalue + " " + zalue);

        anim.transform.rotation = Quaternion.Euler(xvalue, yalue, zalue);
        print(anim.transform.rotation);
    }
}
