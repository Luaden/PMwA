using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float treshold = 20f;

    void Update()
    {
        move();
      if (transform.position.y > treshold)
        {
            SceneManager.LoadScene(2);
        }
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting");
            Application.Quit();

        }
    }

    void move()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizonal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizonal, moveVertical);
        transform.position = transform.position + new Vector3(moveHorizonal * movementSpeed * Time.deltaTime, moveVertical * movementSpeed * Time.deltaTime, 0);
        AudioManager.instance.PlayMusic("Klättra");
    }
}
