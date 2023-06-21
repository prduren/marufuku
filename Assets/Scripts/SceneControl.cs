using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    void Update()
    {

        // if outside of buildings
        if (!StateMachine.buildingEntered) {
            if (Input.GetKey("left")) {
                SceneManager.LoadScene("L1");
            } else if (Input.GetKey("right")) {
                SceneManager.LoadScene("Plaza");
            }
        }

        // if inside of buildings
        if (StateMachine.buildingEntered) {
            if (Input.GetKey("down")) {
                StateMachine.buildingEntered = false;
                SceneManager.LoadScene("Plaza");
            }
        }
         
        // if in Plaza
        if (StateMachine.currentScene == "Plaza") {
            if (Input.GetKey(KeyCode.Alpha1)) {
                StateMachine.buildingEntered = true;
                SceneManager.LoadScene("b-Donuts");
            } else if (Input.GetKey(KeyCode.Alpha2)) {
                StateMachine.buildingEntered = true;
                SceneManager.LoadScene("b-Outdoor");
            } else if (Input.GetKey(KeyCode.Alpha3)) {
                StateMachine.buildingEntered = true;
                SceneManager.LoadScene("b-Groceries");
            } else if (Input.GetKey(KeyCode.Alpha4)) {
                StateMachine.buildingEntered = true;
                SceneManager.LoadScene("b-Gym");
            } else if (Input.GetKey(KeyCode.Alpha5)){
                StateMachine.buildingEntered = true;
                SceneManager.LoadScene("b-Clothes");
            }
        }
        
    }
}
