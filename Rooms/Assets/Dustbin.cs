using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustbin : MonoBehaviour {
    public GameObject Coke;
    // Use this for initialization
    public void ClickDust()
    {
        Coke.SetActive(false);
        UiCoke.instance.CokeCheck = false;
    }
}
