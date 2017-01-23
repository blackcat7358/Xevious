using UnityEngine;
using System.Collections;

public class Logram : MonoBehaviour
{

    public int Arandom;
    public float Trandom;
    public float attack = 0;

    public GameObject tama;

    // Use this for initialization
    void Start()
    {
        Trandom = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        attack += Time.deltaTime;
        if (attack >= Trandom)
        {
            Arandom = Random.Range(0, 4);
            switch (Arandom)
            {
                case 0:
                    Instantiate(tama, transform.position, transform.rotation);
                    break;
                default:
                    break;
            }
            Trandom = Random.Range(0.5f, 1.5f);
            attack = 0;
        }



    }


}
