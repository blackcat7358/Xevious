using UnityEngine;
using System.Collections;

public class Scenemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(new Rect(225, 300, 100, 40), "Button"))
        {
            Application.LoadLevel("Scene01");
        }
    }
}
