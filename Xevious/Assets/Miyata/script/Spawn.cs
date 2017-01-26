using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

    public GameObject[] sporn;
    public GameObject[] Enemy;

    private int i;

    public int j;

    bool instantMode = false;

    // Use this for initialization
    void Start()
    {
        i = 0;
        j = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!instantMode)
        {
            instantMode = true;
            StartCoroutine("instant");
        }
    }
    private IEnumerator instant()
    {
        yield return new WaitForSeconds(50 * Time.deltaTime);
        i = Random.Range(0, 5);
        Instantiate(Enemy[j], sporn[i].transform.position, Quaternion.identity);
        j++;
        if (j == 50)
        {
            j = 0;
        }
        yield return new WaitForSeconds(180 * Time.deltaTime);
        instantMode = false;

    }
}
