using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balas;
    public float cooldown = 2f;
    int i=0;
    void Start()
    {
        balas.transform.localScale = new Vector3(1f, 1f, 1f);
        InvokeRepeating("generarBalas", 0, cooldown);

    }

    // Update is called once per frame
    void Update()
    {
        crearBala();
        agrandarbala();
        achicarbala();

    }

    private void achicarbala()
    {
        if (Input.GetKeyDown(KeyCode.K) && i > -3)
        {
            balas.transform.localScale /= 2f;
            i--;
        }
    }

    private void agrandarbala()
    {
        if (Input.GetKeyDown(KeyCode.J) && i < 2)
        {
            balas.transform.localScale *= 2f;
            i++;
        }
    }

    private void crearBala()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(balas);
    }
    private void generarBalas()
    {
        Instantiate(balas);
    }

}
