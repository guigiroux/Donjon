using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHorizonScript : MonoBehaviour {

    public int Speed;
    public int maxZ;
    public int minZ;
    public bool extremite = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float f = Time.deltaTime * Speed;
        var platform = GetComponent<Transform>();
        if (extremite == false)
        {
            platform.localScale += new Vector3(0, 0, f);
            if (platform.localScale.z >= maxZ)
                extremite = true;
        }
        else if (extremite == true)
        {
            platform.localScale -= new Vector3(0, 0, f);
            if (platform.localScale.z <= minZ)
                extremite = false;
        }
    }
}
