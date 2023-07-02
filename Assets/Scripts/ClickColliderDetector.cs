using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickColliderDetector : MonoBehaviour
{

    private void Update() {
        
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null) {
                if (hit.collider.name == "trashcan") {
                    // clears up to 10 elements in inventory - just to be safe
                    StateMachine.inventory.Clear();
                    ItemController.FilledInventoryCircle.GetComponent<SpriteRenderer>().enabled = false;
                } else if (hit.collider.name == "PassThroughBackground") {
                    foreach (KeyValuePair<string, string> kvp in Objects.reqs) {
                        if (StateMachine.currentScene == kvp.Key) {
                            int numberOfReqs = StateMachine.GetNumberOfReqs(kvp.Value);
                            foreach(var item in StateMachine.inventory) {
                                if (kvp.Value.Contains(item.ToString())) {
                                    // Debug.Log("success!");
                                    StateMachine.passedReqsCounter = StateMachine.passedReqsCounter + 1;
                                } else if (!kvp.Value.Contains(item.ToString())) {
                                    // Debug.Log("failure!");
                                    StateMachine.levelPassed = false;
                                    break;
                                }
                                if (StateMachine.passedReqsCounter == numberOfReqs) {
                                    StateMachine.levelPassed = true;
                                }
                            } 
                        }
                    } if (StateMachine.levelPassed) {
                        string substringedLevelName = StateMachine.currentLevel.Substring(1);
                        int newLevelNumberToLoad = Int32.Parse(substringedLevelName) + 1;
                        Initiate.Fade("L" + newLevelNumberToLoad, Color.black, 10f);
                        StateMachine.levelPassed = false;
                        } else {  
                            Debug.Log("YOU LOST");
                        }
                }
            }
        }
    }
}