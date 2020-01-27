using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{

    public Animator anim;
    public float jumpp = 0;
    public float puc = 0;
    public float inputy;
    public float inputx;
   // public bool jump;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Vertical")*Input.GetAxis("Horizontal");
     
        

        if (inputx >= .2f||inputx<=-.2f|| inputy >= .2f || inputy <= -.2f) 
        {
           anim.SetFloat("run", inputx);
        }      
        if (inputx <= .2f || inputx >= -.2f || inputy <= .2f || inputy >= -.2f) 
        {
         
          anim.SetFloat("run", 0f);
        }
        
       

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jump", true);
            jumpp = 0.0f;
        }
        jumpp += Time.deltaTime;
        if (jumpp > 0.5f)
        {
            anim.SetBool("jump", false);
        }
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("harvest", true);
            puc= 0.0f;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("harvest", true);
            puc= 0.0f;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("harvest", true);
            puc= 0.0f;
        }

        puc += Time.deltaTime;
        if (puc > 0.5f)
        {
            anim.SetBool("harvest", false);
        }
    }
}
