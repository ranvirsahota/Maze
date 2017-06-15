using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer: MonoBehaviour {
    [SerializeField]
    private Transform _playerLocation;
    [SerializeField]
    private Vector3 offset = new Vector3(5,5,5);

    // Use this for initialization
    void Start () {
        offset = this.transform.position - _playerLocation.position;
    }

    private void LateUpdate() {
        this.transform.position = _playerLocation.position + offset;
    }
}
