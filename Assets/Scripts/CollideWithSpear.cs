
using UnityEngine;

public class CollideWithSpear : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Weapon")
        {
            Debug.Log("Ouch");
            GameObject.FindWithTag("MainCamera").GetComponent<Follow>().enabled = false;
        }
    }
}
