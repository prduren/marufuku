using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerRoller : MonoBehaviour
{
    private float timerRollerImageX;
    public GameObject timerRollerImage;
    private bool timerRollerLoaded = false;

    void Start() {
        timerRollerLoaded = true;
        timerRollerImageX = timerRollerImage.transform.position.x;
    }

    void Update() {
        if (timerRollerImage.transform.position.x > -8.04f) {
                    timerRollerImageX = timerRollerImageX - 1f * Time.deltaTime;
        }
        timerRollerImage.transform.position = new Vector3(timerRollerImageX, timerRollerImage.transform.position.y, timerRollerImage.transform.position.z);
        if (timerRollerImage.transform.position.x < -8.04f) {
            Debug.Log("nighttime!");
        }
    }
}
