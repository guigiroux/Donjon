using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerDoor : MonoBehaviour {
    public float timedoor;
    public bool opening;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (opening == true)
        {
            timedoor += Time.deltaTime;
            if (timedoor < 4)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 8, Space.World);
            }
            else
            {
                timedoor = 0;
                opening = false;
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonCharacter")
        {
            opening = true; 
        }
    }
}
