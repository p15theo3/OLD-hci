using UnityEngine;
using System.Collections;

public class Spwner : MonoBehaviour
{
    public GameObject inst;
    public float spawnY;
    public Vector3 spawnPos;
    public float timeToSpawn;
    public float spawnDelay;
    public float spawnerTimer;
    public float spawnerTimerEnd;
    public float scalingTimer;
    public GameManager gm;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("AsteroidSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        spawnY = Random.Range(-5f, 5f);
        spawnPos = new Vector3(10f, spawnY);
        spawnDelay = Random.Range(0.25f, 1f);

        //if (!gm.lost && gm.playing)
            spawnerTimer += Time.deltaTime;

        if (timeToSpawn > 0.2f) //&& gm.playing)
            timeToSpawn -= Time.deltaTime / 128;
    }

    void SpawnAsteroid()
    {
        if (spawnerTimer >= spawnerTimerEnd) //&& gm.playing && !gm.lost)
            Instantiate(inst, spawnPos, Quaternion.Euler(0, 0, Random.Range(0f, 360f)));
    }

    IEnumerator AsteroidSpawner()
    {
        yield return new WaitForSeconds(timeToSpawn + spawnDelay);
        SpawnAsteroid();
        StartCoroutine("AsteroidSpawner");
    }
}