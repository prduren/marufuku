using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Inventory gets entirely reloaded upon going back to L1. Find a way to not load it again every time L1 is loaded.
// TODO: we may need to have a "loader" scene of sorts prior to L1 to load the inventory so it isn't getting double loaded again.
// TODO: timerRoller needs to act on its own in that it gets reset every level. We should be able to still load it with inventory,
// TODO: just reset the x position on level load / new level.

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
