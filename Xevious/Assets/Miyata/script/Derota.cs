﻿using UnityEngine;
using System.Collections;

public class Derota : MonoBehaviour {

    public float attack = 0;
   // public float speed = 1;
   
    public GameObject tama;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        if (this.transform.position.y >= -2.0f)
        {
            attack += Time.deltaTime;
            if (attack >= 1.0f)
            {
                Instantiate(tama, transform.position, transform.rotation);
                attack = 0;
            }
        }
	
	}

}
