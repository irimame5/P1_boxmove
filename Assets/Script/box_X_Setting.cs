using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_X_Setting : MonoBehaviour {

//    public GameObject box_x;
    public Transform box_z;
    public Transform box_me;
	// Use this for initialization
	void Start () {
        box_z = GameObject.Find("Cube_Z").transform;
        box_me = this.transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {

        box_me.transform.parent = box_z.transform;
        Object.Destroy(this.GetComponent("Rigidbody"));
        Object.Destroy(this);
    }

}
