using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWon : MonoBehaviour {
    public bool didPlayerWin;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            didPlayerWin = true;
        }
    }
}
