using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("left")) {
            SceneManager.LoadScene("L1");
        } else if (Input.GetKey("right")) {
            SceneManager.LoadScene("Plaza");
        }
    }
}
