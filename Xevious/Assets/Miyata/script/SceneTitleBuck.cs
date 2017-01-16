using UnityEngine;
using System.Collections;

public class SceneTitleBuck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(225, 300, 100, 40), "Buck"))
        {
            Application.LoadLevel("Title");
        }
    }
}
