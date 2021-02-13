using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowDelete : MonoBehaviour
{
    public Transform Followplatform;
    public Transform camTransform;


    void Update()
    {
        Followplatform.position = new Vector3(camTransform.position.x, camTransform.position.y - 8, 0);
    }
}
