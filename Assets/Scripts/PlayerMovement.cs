using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
   
    void Update()
    {
        move();
      if (transform.position.y == 20)
        {
            SceneManager.LoadScene(2);
        }
    }

    void move()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizonal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizonal, moveVertical);
        transform.position = transform.position + new Vector3(moveHorizonal * movementSpeed * Time.deltaTime, moveVertical * movementSpeed * Time.deltaTime, 0);
    }
}
