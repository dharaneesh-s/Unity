using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action OnRestart;
    public GameObject GameOverCanvas;
    public GameObject Enemy;
    private void OnEnable()

    {
        Playercontroller.OnPlayerDied += GameOver;

    }
    private void OnDisable()
    {
        Playercontroller.OnPlayerDied -= GameOver;
    }

    void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Enemy.SetActive(false);
    }

    public void Restart()
    {
        GameOverCanvas.SetActive(false);
        Enemy.GetComponent<Enemycontroller>().TeleportEnemy();
        Enemy.SetActive(true);

        if (OnRestart!= null)
            OnRestart();
    }



}