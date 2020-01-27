using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class agarrar : MonoBehaviour
{

    public int metal;
    public Text met;
    public int plastico;
 public Text plast; 
    public int papel;
public Text pap;

    public Text tot;
    public Text totfinal;
    public float total;

    // Start is called before the first frame update
    void Start()
    {
        metal = 0;
        plastico = 0;
        papel = 0;
        total = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        totfinal.text = "Score: $ "+total.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("papel"))
        {
            papel++;
            pap.text ="x "+ papel.ToString();
            pap.color = Color.black;
         
        }
        if (col.CompareTag("metal"))
        {
            metal++;
            met.text = "x " + metal.ToString();
            met.color = Color.black;
         
        }
        if (col.CompareTag("plastico"))
        {
            plastico++;
            plast.text = "x " + plastico.ToString();
            plast.color = Color.black;
      
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("recmet")&&Input.GetKeyDown(KeyCode.Q))
        {
           
            if(metal<=0)
            {
                Debug.Log("ya no tienes metal");
                met.text = "x " + metal.ToString();
                met.color = Color.yellow;
            }
            else
            {
              metal--;
                met.text = "x " + metal.ToString();
                met.color = Color.black;
                total = total + 1.50f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recmet")&&Input.GetKeyDown(KeyCode.E))
        {
           
            if(papel<=0)
            {
                Debug.Log("suerte que ya no tienes papel");
                pap.color = Color.blue;
            }
            else
            {
              papel--;
              pap.text = "x " + papel.ToString();
              pap.color = Color.red;
                Debug.Log("idiota esto no es metal");
                total = total - 1.90f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recmet")&&Input.GetKeyDown(KeyCode.R))
        {
           
            if(plastico<=0)
            {
                Debug.Log("suerte que ya no tienes plastico");
                plast.text = "x " + plastico.ToString();
                plast.color = Color.blue;
            }
            else
            {
              plastico--;
                Debug.Log("idiota esto no es metal");
                plast.text = "x " + plastico.ToString();
                plast.color = Color.red;
                total = total  -2.70f;
                tot.text = "$ " + total.ToString();
            }

        }

        if (col.CompareTag("recpape")&&Input.GetKeyDown(KeyCode.E))
        {
           
            if(papel<=0)
            {
                Debug.Log("ya no tienes papel");
                pap.color = Color.yellow;
            }
            else
            {
              papel--;
              pap.text = "x " + papel.ToString();
              pap.color = Color.black;
                total = total + 0.40f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recpape")&&Input.GetKeyDown(KeyCode.Q))
        {
           
            if(metal<=0)
            {
                Debug.Log("suerte que ya no tienes metal");
                met.text = "x " + metal.ToString();
                met.color = Color.blue;


            }
            else
            {
              metal--;
                Debug.Log("idiotaaa");
                met.text = "x " + metal.ToString();
                met.color = Color.red;
                total = total - 1.90f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recpape")&&Input.GetKeyDown(KeyCode.R))
        {
           
            if(plastico<=0)
            {
                Debug.Log("suerte que ya no tienes plastico");
                plast.text = "x " + plastico.ToString();
                plast.color = Color.blue;
            }
            else
            {
              plastico--;
                Debug.Log("porque me haces esto");
                plast.text = "x " + plastico.ToString();
                plast.color = Color.red;
                total = total - 1.60f;
                tot.text = "$ " + total.ToString();
            }

        }

        if (col.CompareTag("recplas")&&Input.GetKeyDown(KeyCode.R))
        {
           
            if(plastico<=0)
            {
                Debug.Log("ya no tienes plastico");
                plast.text = "x " + plastico.ToString();
                plast.color = Color.yellow;
            }
            else
            {
             plastico--;
                plast.text = "x " + plastico.ToString();
                plast.color = Color.black;
                total = total + 1.20f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recplas")&&Input.GetKeyDown(KeyCode.Q))
        {
           
            if(metal<=0)
            {
                Debug.Log("suerte que ya no tienes metal");
                met.text = "x " + metal.ToString();
                met.color = Color.blue;
            }
            else
            {
             metal--;
                Debug.Log("joderrrrrrrrrrrr");
                met.text = "x " + metal.ToString();
                met.color = Color.red;
                total = total - 2.70f;
                tot.text = "$ " + total.ToString();
            }

        }
        if (col.CompareTag("recplas")&&Input.GetKeyDown(KeyCode.E))
        {
           
            if(papel<=0)
            {
                Debug.Log("suerte que ya no tienes papel");
                pap.color = Color.blue;
            }
            else
            {
            papel--;
            pap.text = "x " + papel.ToString();
                Debug.Log("es joda verdad");
                pap.color = Color.red;
                total = total -1.60f;
                tot.text = "$ " + total.ToString();
            }

        }

    }

}
