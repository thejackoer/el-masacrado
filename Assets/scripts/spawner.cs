using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject obj;
    int total;
    public int totallimit;

    bool spaw = true;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(spaw==true)
        spaner();

        timer += Time.deltaTime;
            if(timer>10.0f)
            {
                total = 0;
                timer = 0.0f;
                spaw = true;
            }
    }
    void spaner()
    {
        total++;
        var go = (GameObject)Instantiate(obj, transform.position + new Vector3(Random.Range(10, 100), Random.Range(10, 20), Random.Range(10, 100)), Quaternion.identity);
       
        if (total >= totallimit)
        {
            spaw= false;
            timer =0f;

        }else
        {
           
            spaw = true;
        }
    }

}
