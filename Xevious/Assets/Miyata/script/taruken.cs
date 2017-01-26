using UnityEngine;
using System.Collections;

public class taruken : MonoBehaviour
{

    public float move = 0;//動いた距離
    public float speed;//進行方向 1:左にいるとき -1:右にいるとき
    public float speed2;
    public float speed3;
    public int speedy;
    public float jyoutai = 0;//状態管理 0:左から接近 1:右から接近 2:右に回避 3:左に回避
    public float randam;

    public GameObject tama;

    protected GameObject Player;

    // Use this for initialization
    void Start()
    {
        randam = Random.Range(1.5f,-4.0f);
        speed2 = Random.Range(-1.0f,0);
        speed3 = Random.Range(0, 1.0f);

        speedy = Random.Range(1, -1);

        speed = 1;

        if (Player_move.x_zahyou > transform.position.x)
        {
            jyoutai = 0;
        }
        else if (Player_move.x_zahyou < transform.position.x)
        {
            jyoutai = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 zahyou = transform.position;
        if (jyoutai == 0)//左から接近
        {
            IdouR();//移動プログラム
        }
        else if (jyoutai == 1)//右から接近
        {
            IdouL();
        }
        else if (jyoutai == 2)//左から来た場合の回避
        {
            Idou2();
        }
        else if (jyoutai == 3)//右から来た場合の回避
        {
            Idou3();
        }
        if (zahyou.y < 0)
        {
            if (jyoutai == 0)
            {
                if (Player_move.x_zahyou < transform.position.x)
                {
                    Instantiate(tama, transform.position, transform.rotation);
                    jyoutai = 2;
                }
            }
            if (jyoutai == 1)
            {
                if (Player_move.x_zahyou > transform.position.x)
                {
                    Instantiate(tama, transform.position, transform.rotation);
                    jyoutai = 3;
                }
            }
        }

        if (zahyou.y > 10.75f)
        {
            //Wave.kazu--;
            Destroy(gameObject);
        }
        if (zahyou.x > 5 && jyoutai == 3)
        {
            //Wave.kazu--;
            Destroy(gameObject);
        }
        if (zahyou.x < -5 && jyoutai == 2)
        {
            //Wave.kazu--;
            Destroy(gameObject);
        }
    }
    void IdouR()//右に動く
    {
        transform.Translate(3 * speed * Time.deltaTime, -4 * speed * Time.deltaTime, 0);
    }
    void IdouL()//左に動く
    {
        transform.Translate(-3 * speed * Time.deltaTime, -4 * speed * Time.deltaTime, 0);
    }
    void Idou2()//左に逃げる
    {
        transform.Translate(3 * speed2 * Time.deltaTime, 3 * speedy * Time.deltaTime, 0);
    }
    void Idou3()//右に逃げる
    {
        transform.Translate(3 * speed3 * Time.deltaTime, 3 * speedy * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        //Wave.kazu--;
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }
}