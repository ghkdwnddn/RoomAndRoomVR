using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : MonoBehaviour
{
    public GameObject RedLight;
    public GameObject timebombword;
    public float Time = 1.0f;
    public float WordTime=1.0f;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(RotationLightOff(Time));
    }
    IEnumerator RotationLightOff(float sec)
    {
        RedLight.SetActive(false);
        yield return new WaitForSeconds(sec);
        StartCoroutine(RotationLightOn(Time));
    }
    IEnumerator RotationLightOn(float sec)
    {
        RedLight.SetActive(true);
        yield return new WaitForSeconds(sec);
        StartCoroutine(RotationLightOff(Time));
    }
    public void word()
    {
        timebombword.SetActive(true);
        StartCoroutine(SetOffWord(WordTime));
    }
    IEnumerator SetOffWord(float sec)
    {
        yield return new WaitForSeconds(sec);
        timebombword.SetActive(false);
    }
}
