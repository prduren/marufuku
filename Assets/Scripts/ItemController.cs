using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemController : MonoBehaviour
{

    // grab selected button text, store it
    // if click buy, store text in inventory
    // if inventory full when click buy, throw "inventory full" text

    public GameObject ItemButtons;

    void Start() { 
    }

    void Update() {

    }

    public void AddItemToLimboInventory() {
        StateMachine.limboInventory = EventSystem.current.currentSelectedGameObject.name;
    }

    public void AddItemToInventory() {
        StateMachine.inventory.Add(StateMachine.limboInventory);
        // TODO: add item to inventory UI
    }
}
