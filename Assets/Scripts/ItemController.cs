using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemController : MonoBehaviour
{

    // TODO: if inventory full when click buy, throw "inventory full" text and redirect to trashcan

    // TODO: have amount of inventory circles equal to amount of level reqs

    public GameObject ItemButtons;
    public static GameObject FilledInventoryCircle;

    void Start() { 
        FilledInventoryCircle = GameObject.Find("FilledInventoryCircle");
    }

    void Update() {

    }

    public void AddItemToLimboInventory() {
        StateMachine.limboInventory = EventSystem.current.currentSelectedGameObject.name;
    }

    public void AddItemToInventory() {
        StateMachine.inventory.Add(StateMachine.limboInventory);
        FilledInventoryCircle.GetComponent<SpriteRenderer>().enabled = true;
    }
}
