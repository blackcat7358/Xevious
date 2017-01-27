using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 5.0f || transform.position.x < -5.0f ||
            transform.position.y < -5.5f)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }
}
