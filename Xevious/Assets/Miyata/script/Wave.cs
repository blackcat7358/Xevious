using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {

    public static int kazu;

	// Use this for initialization
	void Start () {

        kazu = 3;
	
	}
	
	// Update is called once per frame
	void Update () {
        if(kazu <= 0)
        {
            Emitter.wave++;
        Destroy(gameObject);
        }
        //
	
	}
}
