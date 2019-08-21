using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int teamGazorp;
    public int teamSquanch;
    private UIManager uiMan;




    public void TeamGazorpScored()
    {
        teamGazorp += 1;
        uiMan.UpdateScore(teamGazorp, teamSquanch);

    }

    public void TeamSquanchScored()
    {
        // ++ is shorthand for +1
        teamSquanch ++;
        uiMan.UpdateScore(teamGazorp, teamSquanch);
    }


    // Start is called before the first frame update
    private void Start()
    {
        uiMan = GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
