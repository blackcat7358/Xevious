using UnityEngine;
using System.Collections;

public class Blaster : MonoBehaviour {
	public float speed;
	public float zahyou;
	public GameObject Pointer;
	public float pointer2;
    public bool flg = false;

	// Use this for initialization
	void Start () {

		//GetComponent<Rigidbody2D>().velocity = transform.up*speed;

		Pointer = GameObject.Find ("Pointer");

		Vector2 pointer = Pointer.transform.position;

		pointer2 = pointer.y;

        //GetComponent<Blaster>().enabled = false;

		GetComponent<CircleCollider2D> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 zahyou2 = transform.position;

		transform.Translate (0, 1 * speed * Time.deltaTime, 0);

        if (zahyou2.y >= pointer2 - 0.3f)
        {
            GetComponent<CircleCollider2D>().enabled = true;
        }
	
		if(zahyou2.y >= pointer2)
		{
<<<<<<< HEAD
=======
			//GetComponent<BoxCollider2D>().enabled = true;

>>>>>>> 4218bcd6a898e9c6de997f0c0375661efdcf8dd0
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D c)
	{
		Destroy(gameObject);        //自機を削除
		//Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        Destroy(gameObject);        //自機を削除
        Destroy(c.gameObject);                            //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }


}
