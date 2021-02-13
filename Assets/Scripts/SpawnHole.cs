using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHole : MonoBehaviour
{
    
    public GameObject hole;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Hole")
        {
            Debug.Log("SpawnHole is working");
            CreateHole();
            Destroy(collision.gameObject);
        }
        if(collision.collider.tag == "Weapon")
        {
            Destroy(collision.gameObject);
        }

    }
    void CreateHole()
    {
       float xPos = Random.Range(-8.9f, 8.9f);
        float yPos = transform.position.y + 15;
        GameObject CreateHole = Instantiate(hole, new Vector3(xPos, yPos, 0), Quaternion.identity) as GameObject;
    }
}
