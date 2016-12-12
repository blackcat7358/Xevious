using UnityEngine;
using System.Collections;

public class Zakato : MonoBehaviour {

    public GameObject Gidosupario;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Instantiate(Gidosupario, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
