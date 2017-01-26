using UnityEngine;
using System.Collections;

public class Zakato : MonoBehaviour {

    public GameObject Gidosupario;
    public GameObject Teki;
    public GameObject Jiki;

    // Use this for initialization
    void Start () {
        Jiki = GameObject.Find("Player1(Clone)");
        var vec = (Jiki.transform.position - Teki.transform.position).normalized;
        var angle = (Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg) - 90.0f;
        Teki.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);

    }
	
	// Update is called once per frame
	void Update () {

        Vector2 zahyou = transform.position;
        Idou();

        if (zahyou.y < 0)
        {
            Instantiate(Gidosupario, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
    void Idou()
    {
        transform.Translate(/*3 * speed * Time.deltaTime*/0, 5 * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        //Wave.kazu--;
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }

}
