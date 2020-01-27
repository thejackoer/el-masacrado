using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{

    GameObject metal;
    GameObject plastic;
    GameObject paper;

    bool met = false;
    
    bool pap = false;
    
    bool pla = false;


    NavMeshAgent obj;
    // Start is called before the first frame update
    void Start()
    {
        metal = GameObject.FindGameObjectWithTag("metal");
        plastic = GameObject.FindGameObjectWithTag("plastico");
        paper = GameObject.FindGameObjectWithTag("papel");
        if(metal==null)
        {
            Debug.Log("dale");
        }
        obj=GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(met==false)
        {
            obj.destination = metal.transform.position;
            

        }
        if (pla==false)
        {
            obj.destination = plastic.transform.position;
       

        }

         if(pap==false)
        {
            obj.destination = paper.transform.position;
   
        }

        if (metal==true)
        {
            
            plastic = GameObject.FindGameObjectWithTag("plastico");
            paper = GameObject.FindGameObjectWithTag("papel");
        }
        if (paper==true)
        {
            metal = GameObject.FindGameObjectWithTag("metal");
            plastic = GameObject.FindGameObjectWithTag("plastico");
          
        }
        if (plastic==true)
        {
            metal = GameObject.FindGameObjectWithTag("metal");
            paper = GameObject.FindGameObjectWithTag("papel");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("metal")&&met==false)
        {
            met = true;
            pla = false;
        }
        if (other.CompareTag("papel")&&pap==false)
        {
            pap = true;
            met = false;

        }
        if (other.CompareTag("plastico")&&pla==false)
        {
            pla = true;
            pap = false;

            
        }
    }
}
