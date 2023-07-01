using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// test

public class Intro : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
                Initiate.Fade("L1", Color.black, 1f);
            }
    }
}
