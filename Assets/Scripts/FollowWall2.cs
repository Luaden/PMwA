using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWall2 : MonoBehaviour
{
    public Transform Followplatform;
    public Transform camTransform;


    void Update()
    {
        Followplatform.position = new Vector3(camTransform.position.x + 9.4f, camTransform.position.y, 0);
    }
}
