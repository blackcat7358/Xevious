using UnityEngine;
using System.Collections;

public class Player_move : MonoBehaviour {
	public float speed;

    public static float x_zahyou;
    public static float y_zahyou;

	public int cnt;
	public GameObject bullet;

    // Use this for initialization
    void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		move ();
		cnt++;
		if(Input.GetKey(KeyCode.Space))
		{
			if(cnt>=10)
			{
				Instantiate (bullet,transform.position, transform.rotation);
				cnt=0;
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
}
