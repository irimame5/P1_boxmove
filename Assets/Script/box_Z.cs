using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_Z : MonoBehaviour {
    public float speed = 2.0f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
        {
            //transform.position += transform.right * speed * Time.deltaTime;
            this.transform.position += new Vector3(speed, 0, 0);
        }
    }
}
