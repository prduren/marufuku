using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    void Start()
    {
        StateMachine.currentLevel = SceneManager.GetActiveScene().name;
        StateMachine.levelPassed = false;
    }
}
