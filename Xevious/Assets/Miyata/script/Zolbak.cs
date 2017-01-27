using UnityEngine;
using System.Collections;

public class Zolbak : MonoBehaviour {

    //private int random = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        //random = Random.Range(1, 4);
        //Spawn.j -= random;
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }
}
