using UnityEngine;
using System.Collections;

public class WaveController : MonoBehaviour {

    public GameObject Wave1;

	// Use this for initialization
	void Start () {
        Instantiate(Wave1, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
