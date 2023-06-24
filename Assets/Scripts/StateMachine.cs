using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateMachine : MonoBehaviour
{
    public static string currentScene;
    public static bool buildingEntered = false;
    public static ArrayList inventory = new ArrayList();
    public static string limboInventory;

    void Start() {
        currentScene = SceneManager.GetActiveScene().name;
    }
}
