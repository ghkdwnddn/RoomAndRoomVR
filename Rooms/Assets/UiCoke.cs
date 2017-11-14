using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiCoke : MonoBehaviour {
    public static UiCoke instance;
    public bool CokeCheck=false;
    public int Count = 0;
    // Use this for initialization
    public void Start()
    {
        CokeCheck = false;
    }
    public void Awake()
    {
        UiCoke.instance = this;
    }
}
