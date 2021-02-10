using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Followplatform;
    public Transform Player;


    void Update()
    {
        Followplatform.position = new Vector3(0, Player.position.y + 3, -10);
    }
}
