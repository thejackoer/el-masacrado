using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basura : MonoBehaviour
{


    public GameObject met;

    void Start()
    {
       // obj=GetComponent<GameObject>();
       // obj.SetActive(true);

    }


    void Update()
    {

    

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
           met.SetActive(false);
            //spawner.total--;
        }

        if (col.CompareTag("basurero"))
        {
           met.SetActive(false);
            //spawner.total--;
        }


    }
}

