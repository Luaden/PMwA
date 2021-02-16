
using UnityEngine;
using UnityEngine.UI;

public class CollideWithSpear : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Weapon")
        {
            Debug.Log("Ouch");
            GameObject.FindWithTag("PlayerTag").GetComponent<Rigidbody2D>().freezeRotation = false;
            GameObject.FindWithTag("MainCamera").GetComponent<Follow>().enabled = false;
            GameObject.FindWithTag("PlayerTag").GetComponent<Rigidbody2D>().gravityScale = 1f;
            GameObject.FindWithTag("PlayerTag").GetComponent<PlayerMovement>().enabled = false;
            GameObject.FindWithTag("PlayerTag").GetComponent<CapsuleCollider2D>().enabled = false;
            canvas.SetActive(true);
        }
    }
}
