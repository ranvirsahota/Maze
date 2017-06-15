using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour {
    [SerializeField]
    private PlayerMovement _playerMovement;
    [SerializeField]
    private CountDownTimer _countDownTimer;
    [SerializeField]
    private CameraFollowPlayer _cameraFollowPlayer;
    [SerializeField]
    private Text _introText;
    [SerializeField]
    private PlayerWon _playerWon;

    private float _restartDelay = 2f;
    private float _restartTimer = 0f;
    public bool isGameRunning;

    // Use this for initialization
    void Start() {
        isGameRunning = false;
    }

    // Update is called once per frame
    void Update() {
        if (isGameRunning == false && Input.GetKeyUp(KeyCode.Space)) {
            _gameStart();
        }

        else if (isGameRunning && (_countDownTimer.isTimerRunning == false || _playerWon.didPlayerWin == true)) {
            _endGame();
            _restart();
        }
    }

    private void _gameStart() {
        isGameRunning = true;
        _playerMovement.enabled = true;
        _countDownTimer.enabled = true;
        _cameraFollowPlayer.enabled = true;
    }

    private void _endGame() {
        _playerMovement.enabled = false;
        _countDownTimer.enabled = false;
        _cameraFollowPlayer.enabled = false;
    }
    private void _restart() {
        _restartTimer += Time.deltaTime;
        if (_restartTimer >= _restartDelay) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
