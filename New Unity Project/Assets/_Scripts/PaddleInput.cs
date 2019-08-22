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
    /*  public string punchAxis;
      private bool punching;
      public float punchPower;

      private Rigidbody paddleRB;
      public float startX;
      public float clampX;
      */


    // Start is called before the first frame update

        
    private void Start()
    {
      /*  startX = transform.position.x;
        paddleRB = GetComponent<Rigidbody>();
        */

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
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            punching = true;
        }

        if(punching == true)
        {
            Punch();
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, startX, clampX), transform.position.y, transform.position.z);
   */

    }

    public void MovePaddle(float inputAxisInfo)
    
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0,inputAxisInfo * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
        
        
    }
   /* public void Punch()
    {
        paddleRB.AddForce(-transform.right * punchPower);
    }
    */

}
