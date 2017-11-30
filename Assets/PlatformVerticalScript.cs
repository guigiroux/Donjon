using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformVerticalScript : MonoBehaviour
{

    public int Speed;
    public int maxY;
    public int minY;
    public bool extremite = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float f = Time.deltaTime * Speed;
        var platform = GetComponent<Transform>();
        if (extremite == false)
        {
            platform.localPosition += new Vector3(0, f, 0);
            if (platform.localPosition.y >= maxY)
                extremite = true;
        }
        else if (extremite == true)
        {
            platform.localPosition -= new Vector3(0, f, 0);
            if (platform.localPosition.y <= minY)
                extremite = false;
        }
    }
}