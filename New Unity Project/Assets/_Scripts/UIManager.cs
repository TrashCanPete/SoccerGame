using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text teamGazorpScore;
    public Text teamSquanchScore;




    // Start is called before the first frame update
    void Start()
    {
        teamGazorpScore.text = "0";
        teamSquanchScore.text = "0";
    }

    public void UpdateScore(int p1score, int p2score)
    {
        teamGazorpScore.text = p1score.ToString();
        teamSquanchScore.text = p2score.ToString();

    }
}
