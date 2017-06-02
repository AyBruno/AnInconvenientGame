using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawnerController : MonoBehaviour {

    //rate at which enemies spawn
    public int nut = 0;
    public float spawnRate = 1;

    //enemy prefab
    public GameObject enemy;

    //bounds of spawner
    public float leftBound = -5F;
    public float rightBound = 5F;


    // Use this for initialization
    void Start()
    {
            InvokeRepeating("SpawnEnemy", 1, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (nut == 7)
        {
            SceneManager.LoadScene("Platformer");
        }
    }

    void SpawnEnemy()
    {
        //a clone of the enemy prefab
        GameObject enemyClone;

        //spawns enemyClone at this location and rotation   
        enemyClone = Instantiate(enemy, this.transform.position, this.transform.rotation) as GameObject;

        //randomly moves spawner along x axis
        float x = Random.Range(leftBound, rightBound);
        transform.position = new Vector3(x, this.transform.position.y, 0);
        nut = nut + 1;
    }
}
