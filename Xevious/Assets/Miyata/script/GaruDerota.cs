using UnityEngine;
using System.Collections;

public class GaruDerota : MonoBehaviour
{

    public float attack = 0;

    public GameObject tama;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        attack += Time.deltaTime;
        if (attack >= 1.0f)
        {
            Instantiate(tama, transform.position, transform.rotation);
            attack = 0;
        }

    }

}