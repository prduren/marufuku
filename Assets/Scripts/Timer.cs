using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //IF USING TEXT MESH PRO

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public Canvas timerTextCanvas; // only referencing for DontDestroyOnLoad bc requires root GameObject

    // public float timeLeft = 30;

    void Start() {
        // DontDestroyOnLoad(gameObject);
    }

    void Update() {

        if (TimerManager.myTimer > 0) {
            TimerManager.myTimer -= Time.deltaTime * 2;

            string minutesLeft = Mathf.FloorToInt(TimerManager.myTimer / 60).ToString();
            string seconds = (TimerManager.myTimer % 60).ToString("F0");
            seconds = seconds.Length == 1 ? seconds = "0" + seconds : seconds;

            timerText.text = minutesLeft + ":" + seconds;
        } else {
            Debug.Log("GAME OVER");
        }
        
    }
}
