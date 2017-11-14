using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FirstRoomSwitch : MonoBehaviour {
    public Material On;
    public Material Off;
    bool ONOFF = true;
    bool TONOFF = false;
    public GameObject lamp;
    public GameObject TOn;
    public GameObject TOFF;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = On;
        lamp.SetActive(false);
	}
    public void LightSwitch()
    {
        ONOFF = !ONOFF;
        if (ONOFF == true)
        {
            GetComponent<Renderer>().material = On;
            lamp.SetActive(false);
        }
        else if (ONOFF == false)
        {
            GetComponent<Renderer>().material = Off;
            lamp.SetActive(true);
        }
    }
    public void TurnOnOFF()
    {
        TONOFF = !TONOFF;
        if (TONOFF == true)
        {
            TOn.SetActive(true);
            StartCoroutine(LightOn(1.0f));
        }
        else if (TONOFF == false)
        {
            TOFF.SetActive(true);
            StartCoroutine(LightOff(1.0f));
        }
    }
    IEnumerator LightOn(float sec)
    {
        yield return new WaitForSeconds(sec);
        TOn.SetActive(false);
    }
    IEnumerator LightOff(float sec)
    {
        yield return new WaitForSeconds(sec);
        TOFF.SetActive(false);
    }
}
