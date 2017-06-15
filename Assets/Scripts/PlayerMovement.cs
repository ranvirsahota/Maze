using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float _speed = 10;
    private Rigidbody _rigidBody;

	// Use this for initialization
	void Start () {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float _horizontalMovement = Input.GetAxis("Horizontal");
        float _verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(_horizontalMovement, 0.0f, _verticalMovement);
        _rigidBody.AddForce(movement * _speed);
    }
}
