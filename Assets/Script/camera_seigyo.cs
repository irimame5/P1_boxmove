using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_seigyo : MonoBehaviour {
    public float speed = 2.0f;
    //適当なGameObject型の変数 gを作成
    public GameObject cube;
    public GameObject Gameover;

    public Transform z_cub;
    public Transform camera_z;
    public bool Gameover_c = false;

    // Use this for initialization
    Vector3 z_cubs;
    void Start () {
        z_cub = GameObject.Find("Cube_Z").transform;
//        UI_gameover = GameObject.Find("GameOver_UI").transform;
        camera_z = this.transform;
    }

    //box_Zの座標を取得、box_Zより右に行かないようにする
    //  transform.parent.GetComponent<box_X>().;

    // Update is called once per frame
    void Update()
    {

        //ゲーム中の処理
        if (Gameover_c == false)
        {
            //Zキーの進行と連動
            if (Input.GetKey(KeyCode.Z))
            {
                //           print(z_cub.position.x + "と" + camera_z.position.x);
                //ボックスを置き去りにしないように
                if (z_cub.position.x > camera_z.position.x - 30.0f)
                {
                    this.transform.position += new Vector3(speed, 0, 0);
                }
            }

            //ボックスがカメラを追い抜いた場合
            if (z_cub.position.x > camera_z.position.x)
            {
                this.transform.position += new Vector3(speed * 2, 0, 0);
            }

            //落下しすぎてゲームオーバーになった場合

            if (z_cub.position.y < -100.0f)
            {

                Gameover.SetActive(true);
                Destroy(cube);
                Gameover_c = true;
            }

        }//ゲーム内処理おわり



    }
}
