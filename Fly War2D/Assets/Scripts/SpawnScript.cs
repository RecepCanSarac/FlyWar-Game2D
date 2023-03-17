using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnPrefab1;
    public float enemy1Timer;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Timer, spawnPrefab1));
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
        StartCoroutine(spawnEnemy(enemy1Timer, spawnPrefab1));

    }
}
