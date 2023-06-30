using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// TODO: successful checks on two items in inv with two requirements
// TODO: FALSE passes with only one item in inventory. Need to fail if all reqs aren't met.
// TODO: increment counter if successful? Counter needs to equal reqNumber for a pass condition?

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
                        Debug.Log("LEVEL PASSED!"); 
                      } else {  
                            Debug.Log("YOU LOST");
                        }
                }
            }
        }
    }
}

/*
// Loop through the requirements
    foreach (Item requirement in tradegoodRequirements)
    {
        // For each requirement check content in warehouse
        foreach (Item content in warehouse.warehouseContent)
        {
            // When content is not requirement skip the check
            if (content.scripableTradegood != requirement.scripableTradegood) continue;

            // When right content was found
            if (content.scripableTradegood == requirement.scripableTradegood)
            {

                // If required content amount isnt present return
                if (content.amount < requirement.amount) return;

                /*
            }
        }
    }
    */