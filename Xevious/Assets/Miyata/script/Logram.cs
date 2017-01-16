using UnityEngine;
using System.Collections;

public class Logram : MonoBehaviour
{

    public int random;
    //public float speed;
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
            random = Random.Range(0, 4);
            switch (random)
            {
                case 0:
                    Instantiate(tama, transform.position, transform.rotation);
                    break;
                default:
                    break;
            }
            attack = 0;
        }



    }


}
