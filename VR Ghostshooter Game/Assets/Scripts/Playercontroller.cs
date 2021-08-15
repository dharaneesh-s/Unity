using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public static Action OnPlayerDied = null;
    public GameObject ballPrefab;
    public Transform ballTransform;
    public float speed = 5.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject tmpBall = Instantiate(ballPrefab, ballTransform.position, ballTransform.rotation);
            tmpBall.GetComponent<Rigidbody>().velocity = ballTransform.forward * speed;
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if(OnPlayerDied!=null)
            OnPlayerDied();
            Debug.Log("player died");
        }


    }
}
