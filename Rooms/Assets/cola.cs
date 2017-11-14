using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cola : MonoBehaviour {
    public GameObject colas;
    public GameObject Coke;
    public GameObject GetCanCoke;
    public void SizeUp()
    {
        colas.transform.localScale = new Vector3(10, 10, 10);
        colas.transform.position = new Vector3(86.69f, 1.1f, 8.48f);
    }
    public void GetCoke()
    {
        if (UiCoke.instance.CokeCheck==false)
        {
            transform.parent = GetCanCoke.transform;
            Collider col = GetComponent<Collider>();
            colas.transform.localScale = new Vector3(10, 10, 10);
            colas.transform.position = new Vector3(0.05f, -0.77f, 12.29f);
            col.enabled = false;

            //colas.transform.localRotation = new Vector3(0.0f, 0.0f, 0.0f);
            //Coke.SetActive(true);
            //colas.SetActive(false);
            UiCoke.instance.CokeCheck = true;
        }
    }
    public void SizeDown()
    {
        colas.transform.localScale = new Vector3(7, 7, 7);
        colas.transform.position = new Vector3(86.69f, 0.41f, 8.48f);
    }
}
