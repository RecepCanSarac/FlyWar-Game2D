using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnPrefab1;
    public GameObject spawnPrefab2;
    public GameObject speedUpgrade;
    public float enemy1Timer;
    public float enemy2Timer;
    public float speedUpgradeTimer;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Timer, spawnPrefab1));
        StartCoroutine(spawnEnemy(enemy2Timer, spawnPrefab2));
        StartCoroutine(spawnEnemy(speedUpgradeTimer, speedUpgrade));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spawnEnemy(float time, GameObject enemy)
    {
        yield return new WaitForSeconds(time);
        int randomSpawn = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[randomSpawn].position, Quaternion.identity);
        StartCoroutine(spawnEnemy(time, enemy));

    }
}
