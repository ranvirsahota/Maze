using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {
    private Text _countDownTimerText;
    private int _mintues;
    private int _seconds;
    public bool isTimerRunning = false;

    // Use this for initialization
    private void Start() {
        _countDownTimerText = GetComponent<Text>();
        _mintues = 5;
        _seconds = 60;
        isTimerRunning = true;
        InvokeRepeating("CountDown", 0f, 1);
    }

    //Method is called every second
    private void CountDown() {
        _seconds--;
        if (_seconds == 59) {
            _mintues--;
        }
        else if (_seconds == 0 && _mintues != 0) {
            _seconds = 60;
        }
        else if (_seconds == 0 && _mintues == 0) {
            isTimerRunning = false;
            CancelInvoke("CountDown");
        }
        _countDownTimerText.text = _mintues.ToString() + ":" + _seconds.ToString();
    }
}