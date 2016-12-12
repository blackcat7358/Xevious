﻿using UnityEngine;
using System.Collections;

public class toroido : MonoBehaviour {


    public float move = 0;//動いた距離
    public float speed ;//進行方向 1:左にいるとき -1:右にいるとき
    public float jyoutai = 0;//状態管理 0:左から接近 1:右から接近 2:右に回避 3:左に回避
	

    void Start()
    {
        if (Player_move.x_zahyou > transform.position.x)
        {
            speed = 1;
            jyoutai = 0;
        }else if(Player_move.x_zahyou < transform.position.x)
        {
            speed = -1;
            jyoutai = 1;
        }
    }

	// Update is called once per frame
	void Update () {

        Idou();//移動プログラム

        if(jyoutai == 1)
        {
            if (Player_move.x_zahyou > transform.position.x)
            {
                speed = 1;
                jyoutai = 3;
            }
        }
        if(jyoutai == 0)
        {
            if(Player_move.x_zahyou < transform.position.x)
            {
                speed = -1;
                jyoutai = 2;
            }
        }
        
        if (move > 1000)//画面外に出たら消したい
        {
            Destroy(gameObject);
        }

	}

    void Idou()
    {
        transform.Translate(1 * speed * Time.deltaTime, -1 * Time.deltaTime, 0);
        move++;
    }
}
