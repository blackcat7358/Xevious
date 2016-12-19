using UnityEngine;
using System.Collections;

public class Zakato : MonoBehaviour {

    public GameObject Gidosupario;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Instantiate(Gidosupario, transform.position, transform.rotation);
        Destroy(gameObject);

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Wave.kazu--;
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }

}
