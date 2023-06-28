using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickColliderDetector : MonoBehaviour
{

    private void Update() {
        
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            Debug.Log(hit.collider);
            if (hit.collider != null) {
                if (hit.collider.name == "trashcan") {
                    // clears up to 10 elements in inventory - just to be safe
                    StateMachine.inventory.Clear();
                    ItemController.FilledInventoryCircle.GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
    }
}
