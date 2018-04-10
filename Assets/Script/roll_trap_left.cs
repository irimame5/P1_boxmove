using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll_trap_left : MonoBehaviour {

    public float rolling=5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, -rolling, 0));
    }
}
