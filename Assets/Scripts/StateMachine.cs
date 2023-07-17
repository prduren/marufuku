using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// TODO: set originalTimerRollerPos to OG pos so we can reset it every level

public class StateMachine : MonoBehaviour
{
    public static string currentScene;
    public static bool buildingEntered = false;
    public static ArrayList inventory = new ArrayList();
    public static string limboInventory;
    public static ArrayList levelRequirements = new ArrayList();
    public static bool levelPassed = false;
    public static int passedReqsCounter = 0;
    public static string currentLevel;
    public static int currentLevelNumber;
    public static bool inventoryHasBeenLoaded = false;
    public static Vector3 originalTimerRollerPos;

    void Start() {
        currentScene = SceneManager.GetActiveScene().name;
    }

    public static int GetNumberOfReqs(string stringToSplit) {
        int counter = 0;
        string[] textSplit = stringToSplit.Split(",");
        foreach(string thing in textSplit) {
            counter = counter + 1;
        }
        return counter;
    }
}
