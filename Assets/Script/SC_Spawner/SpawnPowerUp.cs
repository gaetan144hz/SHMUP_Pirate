using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    [SerializeField]
    private GameObject health;
    [SerializeField]
    private GameObject barils;

    public Transform[] spawnPoints;

    [SerializeField]
    private float healthInterval = 3.5f;
    [SerializeField]
    private float barilsInterval = 10f;

    void Start()
    {
        StartCoroutine(spawnEnemy(healthInterval, health));
        StartCoroutine(spawnEnemy(barilsInterval, barils));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        var randomNum = Random.Range(0, 3);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[randomNum].position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}