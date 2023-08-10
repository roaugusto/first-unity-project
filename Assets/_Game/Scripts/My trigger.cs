using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mytrigger : MonoBehaviour
{
    private GameController gameController;


    private void Start(){
        gameController = FindAnyObjectByType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("Destroyer")) {
            Destroy(this.gameObject);
        } else if (target.gameObject.CompareTag("Point")) {
            gameController.score++;
            Destroy(this.gameObject);
        }
    }
}
