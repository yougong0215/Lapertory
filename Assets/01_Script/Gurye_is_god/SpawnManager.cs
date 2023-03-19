using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Vector3 SpanwArea;
    [SerializeField] private float Spawntimer;
    [SerializeField] private GameObject Player;
    private float curtime;
    void Start()
    {

    }

    void Update()
    {
        curtime -= Time.deltaTime;

        if (curtime < 0)
        {
            SpawnEnemy();
            curtime = Spawntimer;
        }
    }

    private Vector3 SpawnPos()
    {
        Vector3 pos;


        float r = UnityEngine.Random.value > 0.5f ? -1 : 1f;
        if (UnityEngine.Random.value > 0.5f)
        {
            pos.x = UnityEngine.Random.Range(-SpanwArea.x, SpanwArea.x);
            pos.z = SpanwArea.z * r;
        }
        else
        {
            pos.z = UnityEngine.Random.Range(-SpanwArea.z, SpanwArea.z);
            pos.x = SpanwArea.x * r;
        }

        pos.y = 0;

        return pos;
    }

    private void SpawnEnemy()
    {
        Vector3 pos = SpawnPos();

        pos += Player.transform.position;

        var Enemy = Instantiate(enemyPrefab);
        Enemy.transform.position = pos;
    }
}
