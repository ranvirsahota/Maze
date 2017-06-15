using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {
    [SerializeField]
    private PlayerWon _playerWon;
    [SerializeField]
    private CountDownTimer _countDownTimer;
    [SerializeField]
    private GameStateManager _gameStateManger;


    private Text _text;

	// Use this for initialization
	void Start () {
        _text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (_gameStateManger.isGameRunning && _countDownTimer.isTimerRunning && _playerWon.didPlayerWin == false) {
            _text.text = "";
        }
		if (_playerWon.didPlayerWin == true) {
            _text.text = "You solved the Maze!!";
        }
        else if (!_countDownTimer.isTimerRunning && _gameStateManger.isGameRunning == true) {
            _text.text = "You Lost, You Run Out OF Time!";
        }
	}
}
