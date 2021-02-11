using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpear : MonoBehaviour
{
    [SerializeField] protected Transform playerTransform;
    [SerializeField] protected GameObject spearObject;
    [SerializeField] protected float spawnTimer;
    [SerializeField] protected Vector2 spearXOffsetMinMax;
    [SerializeField]
    protected float spawnYOffset;

    protected Transform camTransform;

    protected float currentTimer;

    protected void Awake()
    {
        camTransform = GetComponent<Transform>();
    }

    protected void Update()
    {
        TimerCountdown();
    }

    protected void TimerCountdown()
    {
        if (currentTimer <= 0f)
        {
            currentTimer = spawnTimer;
            SpawnWeapon();
        }
        currentTimer -= Time.deltaTime;
    }
    protected void SpawnWeapon()
    {
        float xPos = Random.Range(spearXOffsetMinMax.x, spearXOffsetMinMax.y);
        xPos = Random.Range(xPos + playerTransform.position.x, playerTransform.position.x - xPos);
        float yPos = transform.position.y + spawnYOffset;

        GameObject newSpear = Instantiate(spearObject, new Vector3(xPos, yPos, 0), Quaternion.identity, this.transform);
    }
}
