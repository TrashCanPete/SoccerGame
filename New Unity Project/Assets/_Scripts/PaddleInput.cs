using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    public float speed;
    public float clampValue;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Vertical"));

    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0,inputAxisInfo * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
        
        
    }


}
