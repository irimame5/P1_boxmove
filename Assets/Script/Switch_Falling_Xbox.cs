using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Falling_Xbox : MonoBehaviour {

    public bool OK = false;
    public GameObject box_X;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider t)
    {
        if (OK == false)
        {
            OK = true;

            Instantiate(box_X, new Vector3(1137.0f, 70.0f, 0f), Quaternion.identity);
        }
    }
}
