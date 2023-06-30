using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// TODO: fix hard coding of level. Set active level name at level load?

public class SceneControl : MonoBehaviour
{

    void Update()
    {

        // if outside of buildings
        if (!StateMachine.buildingEntered) {
            if (Input.GetKey("left") && StateMachine.currentScene != "L2") {
                Initiate.Fade("L2", Color.black, 10f);
            } else if (Input.GetKey("right") && StateMachine.currentScene != "Plaza") {
                Initiate.Fade("Plaza", Color.black, 10f);
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
            } else if (Input.GetKey(KeyCode.LeftShift)) {
                SceneManager.LoadScene("Directory");
            }
        }

        // if in directory
        if (StateMachine.currentScene == "Directory") {
            if (Input.GetKey(KeyCode.LeftShift)) {
                SceneManager.LoadScene("Plaza");
            }
        }
        
    }
}
