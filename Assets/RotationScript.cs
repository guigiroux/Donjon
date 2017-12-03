using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {
    public int Speed;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        float f = Time.deltaTime * Speed;
        var platform = GetComponent<Transform>();
        platform.Rotate(new Vector3(0, f, 0));
    }
}
