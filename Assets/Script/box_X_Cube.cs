using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_X_Cube : MonoBehaviour {

    public float jumper = 4.0f;
    public float jump_NOW = 0.0f;
    public float jump_GEND = 15.0f;
    public bool jump_OK = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X) && jump_NOW < jump_GEND && jump_OK == true)
        {
            this.transform.position += new Vector3(0, jumper, 0);
            jump_NOW += 1.0f;
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            jump_NOW = jump_GEND;
            jump_OK = false;
        }
    }

    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision collision)
    {
        //transform.parent.GetComponent<box_X>().
        jump_OK = true;
        //transform.parent.GetComponent<box_X>().
        jump_NOW =0;
//        transform.parent.GetComponent<box_X>().;
    }

    //オブジェクトが離れた時
    void OnCollisionExit(Collision collision)
    {
        if (Input.GetKey(KeyCode.X)) { }
        else
        {
            jump_OK = false;
        }
    }
}
