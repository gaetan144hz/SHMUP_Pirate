using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerV2 : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;

    public Transform[] spawnPoints;

    [SerializeField]
    private float marineNiv1;
    [SerializeField]
    private float pirateNiv1;
    [SerializeField]
    private float marineNiv2;
    [SerializeField] 
    private float pirateNiv2;

    void Start()
    {
        StartCoroutine(spawnEnemy(marineNiv1, prefabs[0]));
        StartCoroutine(spawnEnemy(pirateNiv1, prefabs[1]));
        StartCoroutine(spawnEnemy(marineNiv2, prefabs[2]));
        StartCoroutine(spawnEnemy(pirateNiv2, prefabs[3]));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        var randomNum = Random.Range(0, 3);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[randomNum].position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        yield return new WaitForSeconds(interval);
    }
}