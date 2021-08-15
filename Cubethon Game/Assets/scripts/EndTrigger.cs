
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManagaer gameManagaer;
    void OnTriggerEnter()
    {

        gameManagaer.CompleteLevel();
} }