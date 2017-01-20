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

		Vector2 zahyou2 = transform.position;

		zahyou = zahyou2.y;

		Pointer = GameObject.Find ("Pointer");

		Vector2 pointer = Pointer.transform.position;

		pointer2 = pointer.y;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, 1 * speed * Time.deltaTime, 0);
	
		if(zahyou >= pointer2)
		{
			Destroy (gameObject);

		}

	}
}
