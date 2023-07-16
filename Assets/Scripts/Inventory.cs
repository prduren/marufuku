using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        if (!StateMachine.inventoryHasBeenLoaded) {
            DontDestroyOnLoad(gameObject);
        }
        StateMachine.inventoryHasBeenLoaded = true;
    }

    void Update()
    {
        if (StateMachine.currentScene == "LoaderScene") {
            SceneManager.LoadScene("L1");
        }
        
    }
}
