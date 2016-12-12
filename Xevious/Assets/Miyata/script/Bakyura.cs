using UnityEngine;
using System.Collections;

public class Bakyura : MonoBehaviour {

    public float move = 0;//動いた距離
    public float speed;//進行方向 1:左にいるとき -1:右にいるとき
    public float jyoutai = 0;//状態管理 0:左から接近 1:右から接近 2:右に回避 3:左に回避

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Idou();

        Vector2 zahyou = transform.position;

        if (zahyou.y < -4.75f)
        {
            Destroy(gameObject);
        }

    }

    void Idou()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
        move++;
    }
}
