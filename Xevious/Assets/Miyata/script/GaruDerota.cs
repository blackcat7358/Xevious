using UnityEngine;
using System.Collections;

public class GaruDerota : MonoBehaviour
{

    public float attack = 0;

    public GameObject tama;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 4.8f)
        {
            attack += Time.deltaTime;
            if (attack >= 1.0f)
            {
                Instantiate(tama, transform.position, transform.rotation);
                attack = 0;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Destroy(gameObject);        //自機を削除
                                    //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }

}