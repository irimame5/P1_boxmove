using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift_up_down : MonoBehaviour {
    public float GEND = 20.0f;
    public int muki = 0;
    public float speed = 10.0f;
    public float now_num = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (now_num <= GEND && now_num >= -GEND)
            //限界超えてないか
        {

            if (muki == 0)//上方向
            {
                transform.position += transform.up * speed * Time.deltaTime;
                now_num++;
            }else if(muki == 1)//下方向
            {
                transform.position -= transform.up * speed * Time.deltaTime;
                now_num--;
            }

        }//限界オーバー時
        else if (now_num > GEND)//上限オーバー
        {
            muki = 1;
            now_num--;

        }else if(now_num < -GEND)//下限オーバー
        {
            muki = 0;
            now_num++;
        }


    }
}
