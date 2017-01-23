using UnityEngine;
using System.Collections;

public class Blaster : MonoBehaviour {
	public float speed;
	public float zahyou;
	public GameObject Pointer;
	public float pointer2;

	// Use this for initialization
	void Start () {

		//GetComponent<Rigidbody2D>().velocity = transform.up*speed;

		Pointer = GameObject.Find ("Pointer");

		Vector2 pointer = Pointer.transform.position;

		pointer2 = pointer.y;

		GetComponent<BoxCollider2D> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 zahyou2 = transform.position;

		transform.Translate (0, 1 * speed * Time.deltaTime, 0);
	
		if(zahyou2.y >= pointer2)
		{
			GetComponent<BoxCollider2D>().enabled = true;

			Destroy (gameObject);

		}

	}
}
