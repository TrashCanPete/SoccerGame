using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int teamGazorp;
    public int teamSquanch;


    public void TeamGazorpScored()
    {
        teamGazorp += 1;
    }

    public void TeamSquanchScored()
    {
        teamSquanch += 1;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
