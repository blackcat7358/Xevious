using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed=10.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up*speed;
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 zahyou = transform.position;

        if (zahyou.y >= 4.75f)
        {
            Destroy(gameObject);
        }

	}

    void OnTriggerEnter2D(Collider2D c)
    {
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }
}
