using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public float speed;
    public float xRange;
    public float yRange;
    public float zRange;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.forward * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            TeleportEnemy();
        }
    }
    public void TeleportEnemy()
    {
        float newX = Random.Range(-xRange, xRange);
        float newY = Random.Range(0, yRange);
        float newZ = Random.Range(-zRange, zRange);

        float tmpNumber = Random.Range(0, 1);

        transform.position = new Vector3(newX, newY, newZ);
        transform.LookAt(Camera.main.transform);
    }
    }




