using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D c)
    {
         Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }
}
