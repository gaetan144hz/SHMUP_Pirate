using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    private Timer _timer;
    public GameObject KrakenPrefab;
    public Transform spwnPoint;
    private bool bossSpawned;
    [SerializeField] private float timeToSpawn;
    
    void Start()
    {
        _timer = FindObjectOfType<Timer>();
    }

    void Update()
    {
        if (!bossSpawned && _timer.currentTime >= timeToSpawn)
        {
            bossSpawn();
        }
    }

    public void bossSpawn()
    {
        //timeToSpawn += 50;  
        bossSpawned = true;
        Instantiate(KrakenPrefab, spwnPoint.position, Quaternion.identity);
    }
}
