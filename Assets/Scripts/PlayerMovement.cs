using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
   
    void FixedUpdate()
    {
        
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizonal = Input.GetAxis("Horizontal");


        Vector2 movement = new Vector2(moveHorizonal, moveVertical);

        transform.position = transform.position + new Vector3(moveHorizonal * movementSpeed *Time.deltaTime, moveVertical * movementSpeed * Time.deltaTime, 0);

    }
}
