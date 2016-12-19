using UnityEngine;
using System.Collections;

public class Gidosupario : MonoBehaviour {

    public float move = 0;//動いた距離
    public float speed;//進行方向 1:左にいるとき -1:右にいるとき
    public float jyoutai = 0;//状態管理 0:左から接近 1:右から接近 2:右に回避 3:左に回避
    public float x;
    public float y;
    public GameObject Teki;
    public GameObject Jiki;

    // Use this for initialization
    void Start () {

        Jiki = GameObject.Find("Player");
        var vec = (Jiki.transform.position - Teki.transform.position).normalized;
        var angle = (Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg) - 90.0f;
        Teki.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
        


    }
	
	// Update is called once per frame
	void Update () {

        Vector2 zahyou = transform.position;

        Idou();

        if (zahyou.y < -4.75f)
        {
            Wave.kazu--;
            Destroy(gameObject);
        }

    }
    void Idou()
    {
        transform.Translate(/*3 * speed * Time.deltaTime*/0, 5 * Time.deltaTime, 0);
        move++;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Wave.kazu--;
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }

}
