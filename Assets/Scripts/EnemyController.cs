using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

    //speed of Enemy
    public float speed = 8F;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movement of Enemy
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        //Checks if other gameobject has a Tag of Player
        if (other.gameObject.tag == "Player")
        {
            //Pauses gameplay
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
