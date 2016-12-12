using UnityEngine;
using System.Collections;

public class taruken : MonoBehaviour {

    public float move = 0;//動いた距離
    public float speed;//進行方向 1:左にいるとき -1:右にいるとき
    public float speed2;
    public float jyoutai = 0;//状態管理 0:左から接近 1:右から接近 2:右に回避 3:左に回避

    // Use this for initialization
    void Start () {
        if (Player_move.x_zahyou > transform.position.x)
        {
            speed = 1;
            jyoutai = 0;
        }
        else if (Player_move.x_zahyou < transform.position.x)
        {
            speed = -1;
            jyoutai = 1;
        }
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 zahyou = transform.position;
        Idou();//移動プログラム

        if (jyoutai == 1)
        {
            if (Player_move.x_zahyou > transform.position.x)
            {
                speed = 1;
                jyoutai = 3;
                speed2 = -1;
            }
        }
        if (jyoutai == 0)
        {
            if (Player_move.x_zahyou < transform.position.x)
            {
                speed = -1;
                jyoutai = 2;
                speed2 = -1;
            }
        }

        if (zahyou.y > 4.75f)
        {
            Destroy(gameObject);
        }

    }
    void Idou()
    {
        transform.Translate(1 * speed * Time.deltaTime, -1 * speed2* Time.deltaTime, 0);
        move++;
    }
}
