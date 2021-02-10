using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpear : MonoBehaviour
{
    public GameObject spear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void SpawnWeapon()
    {
        Debug.Log("Spawned a spear :3");
        int xPos = Random.Range(-7, 7);
        int yPos = Random.Range(-4, 4);
        GameObject a = Instantiate(spear) as GameObject;
        a.transform.position = new Vector2(xPos, yPos);

    }
}
