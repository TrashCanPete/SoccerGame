using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    player1,
    player2
}

public class PaddleInput : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed;
    public float clampValue;
    public string axisName;



    // Start is called before the first frame update
    private void Start()
    {
        if(playerSetting == PlayerController.player1)
        {
            axisName = "player1";
        }
        if(playerSetting == PlayerController.player2)
        {
            axisName = "player2";
        }

    }


    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis(axisName));

    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0,inputAxisInfo * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
        
        
    }


}
