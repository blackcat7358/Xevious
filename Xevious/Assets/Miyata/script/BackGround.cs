using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, -0.02f, 0);
        if (transform.position.y < -1000f)
        {
            transform.position = new Vector3(0, 15, 0);
        }
	
	}
}
