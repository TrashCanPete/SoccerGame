using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager instance;
    private List<int> potentialAngles = new List<int> { 60, -60, 240, -240 }; 


    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        int Index = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(0, potentialAngles[Index], 0));

        //This sets the ball to spawn at a random rotation between 30 dgrees and 360. 
        //GameObject ballCopy = Instantiate(ball, Vector3.zero, Quaternion.Euler(0, Random.Range(30, 360), 0));




    }



}