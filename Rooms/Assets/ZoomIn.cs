using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour {
    public GameObject zoom;
    public GameObject cctv;
    public static ZoomIn instance;
    public int count = 0;
    void Awake()
    {
        ZoomIn.instance = this;
    }
    public void ClickZoomEnter()
    {
        count += 1;
        zoom.transform.localScale = new Vector3(0.2646686f, 0.4f, 2.0f);
        if (count == 1)
        {
            cctv.transform.position = new Vector3(79.56f,9.8f,10.1f);
        }
        else if (count == 2)
        {
            cctv.transform.position = new Vector3(89.3f, 9.8f, 10.1f);
        }
        else if (count == 3)
        {
            cctv.transform.position = new Vector3(96.4f, 9.8f, 10.1f);
        }
    }
    public void ZoomExit()
    {
        zoom.transform.localScale = new Vector3(0.2646686f, 0.2832061f, 1.725819f);
    }
     void Update()
    {
        count=Mathf.Clamp(count, 0, 3);
    }
}
