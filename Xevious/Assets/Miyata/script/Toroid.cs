using UnityEngine;
using System.Collections;

public class Toroid : MonoBehaviour {

    public float speed = 0.05f;
    public int joutai = 0;


	// Use this for initialization
	void Start () {
        Player.x = GameObject.Find("Player").transform.position.x;
        if (Player.x < this.x)
        {
            this.x -= 0.05f;
        }
	}
	
	// Update is called once per frame
	void Update () {
        	
	}
}
