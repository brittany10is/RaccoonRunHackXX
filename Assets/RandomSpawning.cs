using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomSpawning : MonoBehaviour {

    public GameObject[] gameObjectArray;
    private float xCoWall = (float)0.1;
    private float yCoWall = (float)0.1016611;
    private float zCoWall = (float)23.3;

    public int score;
    public Text scoreText;
    public Text yourScore;
    private int check = 1;

    int randomObject;
    private int speed=5;
    private Vector3 velocity;

	// Use this for initialization
	void Start () {
        score= 0;
        SetScoreText();
        yourScore.text = "";
        velocity = new Vector3(0, 0, -3.0f);
        StartNewWall();
	}
    void StartNewWall()
    {
        randomObject = Random.Range(0, 4);
        gameObjectArray[randomObject].transform.position = new Vector3(xCoWall, yCoWall, zCoWall);
        gameObjectArray[randomObject].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        gameObjectArray[randomObject].transform.position += velocity * Time.deltaTime;
        //print(score);
        if(gameObjectArray[randomObject].transform.position.z<-20 && gameObjectArray[randomObject].transform.position.z!=zCoWall)
        {
            EndNewWall();
        }
        if(score%5==0 && score!=0)
        {
            velocity = velocity +new Vector3(0,0,-0.01f);
        }
       
    }

    void EndNewWall()
    {
        gameObjectArray[randomObject].SetActive(false);
        gameObjectArray[randomObject].transform.position = new Vector3(xCoWall, yCoWall, zCoWall);
        score++;
        SetScoreText();
        StartNewWall();

    }


    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }

}
