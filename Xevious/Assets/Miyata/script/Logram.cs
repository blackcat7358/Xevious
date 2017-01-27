using UnityEngine;
using System.Collections;

public class Logram : MonoBehaviour
{

    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    public int Arandom;
    public float Trandom;
    public float attack = 0;

    public GameObject tama;
   // public GameObject Blaster;

    // Use this for initialization
    void Start()
    {
        Trandom = Random.Range(0.5f, 1.5f);
        //gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 4.8f)
        {
            attack += Time.deltaTime;
            if (attack >= Trandom)
            {
                Arandom = Random.Range(0, 4);
                switch (Arandom)
                {
                    case 0:
                        Instantiate(tama, transform.position, transform.rotation);
                        break;
                    default:
                        break;
                }
                Trandom = Random.Range(0.5f, 1.5f);
                attack = 0;
            }
        }



    }

    void OnTriggerEnter2D(Collider2D c)
    {
        //Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除

        gameObject.SetActive(false);
    }

    


}


