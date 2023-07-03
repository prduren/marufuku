using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
    }
}
