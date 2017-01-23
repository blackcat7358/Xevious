using UnityEngine;
using System.Collections;

public class Domogram : MonoBehaviour {

    public Vector2 speed = new Vector2(0.03f, 0.03f); 
    // ターゲットとなるオブジェクト 
    public GameObject[] targetObject;
    // ラジアン変数 
    private float rad; 
    // 現在位置を代入する為の変数 
	private Vector2 Position;

    private int i = 0;


    // Use this for initialization 
void Start()
    {
        
    }
     
 
	// Update is called once per frame 
 	void Update()
    {

         // ラジアン 
         // atan2(目標方向のy座標 - 初期位置のy座標, 目標方向のx座標 - 初期位置のx座標) 
         // これでラジアンが出る。
         // このラジアンをCosやSinに使い、特定の方向へ進むことが出来る。 
         rad = Mathf.Atan2(
            targetObject[i].transform.position.y - transform.position.y,
            targetObject[i].transform.position.x - transform.position.x);

         if (transform.position.y < 4.75f)
         {
             // 現在位置をPositionに代入 
             Position = transform.position;
             // x += SPEED * cos(ラジアン) 
             // y += SPEED * sin(ラジアン) 
             // これで特定の方向へ向かって進んでいく。 
             Position.x += speed.x * Mathf.Cos(rad);
             Position.y += speed.y * Mathf.Sin(rad);
             // 現在の位置に加算減算を行ったPositionを代入する 
             transform.position = Position;

         }

        
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        i++;
    }

}
