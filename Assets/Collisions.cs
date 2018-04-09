using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {

    //public GameObject gameObject;


    void OnTriggerEnter(Collider other)
    {

        //gameObject.AddComponent<RandomSpawning>(); //add
        
        //Destroy(gameObject.GetComponent<RandomSpawning>()); //remove
        //print("Hit " + other.gameObject.name); 
        if (other.gameObject.CompareTag("Bush"))
        {
            (transform.GetComponentInParent<RandomSpawning>()).enabled = false;
            other.gameObject.SetActive(false);
        }
        //GameObject camera = GameObject.Find("[CameraRig]/Camera (head)/Camera (eye)");
        //var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        //videoPlayer.url = "Game Over.mov";
        //videoPlayer.Play();
    }
}
