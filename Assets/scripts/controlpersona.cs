using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpersona : MonoBehaviour
{
    public float vel = 0.2f;
    public float jumpvel = 0.05f;
    public float caida = 1.0f;

    //public Animator anim;
    public CharacterController control;


    private Vector3 direc;


    void Start()
    {
        //anim = GetComponent<Animator>();
        control = GetComponent<CharacterController>();
    }

   
    void LateUpdate()
    {

        //  direc=  new Vector3(Input.GetAxis("Horizontal") * vel, direc.y,Input.GetAxis("Vertical") * vel);
        float posy = direc.y;
        direc = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
      //  anim.SetFloat("run",vel);
        direc = direc.normalized * vel;
        direc.y = posy;

        if (control.isGrounded)
        {
            direc.y = 0.0f;
            if (Input.GetButtonDown("Jump"))
            {
                direc.y = jumpvel;
            }
        }
        direc.y = direc.y + (Physics.gravity.y * caida);
        control.Move(direc * Time.deltaTime);
    }
}

