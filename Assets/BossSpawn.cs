using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    private Timer _timer;
    public GameObject KrakenPrefab;
    public Transform spwnPoint;
    [SerializeField] private float timeToSpawn;
    
    void Start()
    {
        _timer = FindObjectOfType<Timer>();
    }

    void Update()
    {
        bossSpawn();
    }

    public void bossSpawn()
    {
        if (_timer.currentTime >= timeToSpawn)
        {
            Instantiate(KrakenPrefab, spwnPoint.position, Quaternion.identity);
        }
    }
}
