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
	    {"L3", "GetStrong, Canoe"},
		{"L4", "Cheese, Tomato, Cabbage"},
	    {"L5", "Carrot"},
	    {"L6", "HikingBoots, RainJacket, Carrot"},
		{"L7", "LoseWeight"},
	    {"L8", "RainJacket, Canoe"},
	    {"L9", "GetStrong, Canoe"},
		{"L10", "RainJacket"},
    };
}

    
