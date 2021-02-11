
using UnityEngine;

public class CollideWithSpear : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Weapon")
        {
            Debug.Log("Ouch");
            GameObject.FindWithTag("MainCamera").GetComponent<Follow>().enabled = false;
            GameObject.FindWithTag("PlayerTag").GetComponent<Rigidbody2D>().gravityScale = 1f;
            GameObject.FindWithTag("PlayerTag").GetComponent<PlayerMovement>().enabled = false;
           
        }
    }
}
