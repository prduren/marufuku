using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Objects : MonoBehaviour
{

    public static Dictionary<string, string> reqs = new Dictionary<string, string>(){
	    {"L1", "RainJacket"},
	    {"L2", "RainJacket, Canoe"},
	    {"L3", "GetStrong, Canoe"}
    };
}

    
