using UnityEngine;
using System.Collections;

public class AndorGenesis : MonoBehaviour {

    //public int flg=0;
    public float speed=1.0f;



	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= 1.0f) {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        /*if (flg == 1)
        {
            
        }*/
	}
}
