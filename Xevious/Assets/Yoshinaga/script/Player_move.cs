using UnityEngine;
using System.Collections;

public class Player_move : MonoBehaviour {
	public float speed;

    public static float x_zahyou;
    public static float y_zahyou;

    public int cnt;

    public float TimeOut = 0.5f;
    public float TimeElapsed;
	public GameObject bullet;
	public GameObject blaster;
   
	
    // Use this for initialization
    void Start () {
      
	
	}
	
	// Update is called once per frame
	void Update () {
		move ();
		cnt++;

        TimeElapsed += Time.deltaTime;
		if(Input.GetKey(KeyCode.Space))
		{
            if (TimeElapsed >= TimeOut)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                TimeElapsed = 0;
            }
        }

		TimeElapsed += Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.C))
		{
			if (TimeElapsed >= TimeOut)
			{
				Instantiate(blaster, transform.position, transform.rotation);
               
				TimeElapsed = 0;
			}
		}

        Vector2 zahyou = transform.position;
        x_zahyou = zahyou.x;
        y_zahyou = zahyou.y;

        if (zahyou.x > 3.75f) {
			zahyou.x = 3.75f;
			transform.position=zahyou;
		}
		if (zahyou.x < -3.75f) {
			zahyou.x = -3.75f;
			transform.position=zahyou;
		}
		if (zahyou.y > 4.75f) {
			zahyou.y = 4.75f;
			transform.position=zahyou;
		}
		if (zahyou.y < -4.75f) {
			zahyou.y = -4.75f;
			transform.position=zahyou;
		}
	}

	void move(){
		if (Input.GetKey ("up")) {
			transform.Translate (0, 1 * speed * Time.deltaTime, 0);
		} else if (Input.GetKey ("down")) {
			transform.Translate (0, -1 * speed * Time.deltaTime, 0);
		} else if (Input.GetKey ("right")) {
			transform.Translate (1 * speed * Time.deltaTime, 0,0);
		} else if (Input.GetKey ("left")) {
			transform.Translate (-1 * speed * Time.deltaTime, 0,0);
		}
    }

void OnTriggerEnter2D(Collider2D c)
    {
		Application.LoadLevel("Title");
        Destroy(gameObject);        //自機を削除
        //Destroy(c.gameObject);  //衝突した相手(敵の弾)の削除
    }

}
