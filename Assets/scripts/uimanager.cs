using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{
    public Text counter;
    public float sec, min;
    private bool acaba=false;
    public Canvas caan;

    public GameObject goback;

    // Start is called before the first frame update
    void Start()
    {
        // counter = GetComponent<Text>() as Text;
        acaba = false;
        min = 0.0f;
        sec = 0.0f;

        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        //if(acaba==false)
        //{
        //min = (int)(Time.time / 60f);
        //sec = (int)(Time.time % 60f);
        //counter.text = min.ToString("00") + ":" + sec.ToString("00");

        //}

        //if(min>=1f)
        //{
        //    goback.SetActive(true);
        //    acaba = true;



        //    return;
        //}
        //if (acaba == true)
        //{
        //    Time.timeScale = 0.0f;
        //    goback.SetActive(true);

        //}

    }

    IEnumerator Timer()
    {


        yield return new WaitForSeconds(1);



        if (acaba == false)
        {
            sec++; //(int)(Time.time % 60f);
            if(sec== 60)
            {
                min++;// = //(int)(Time.time / 60f);
                sec = 0;
            }
            counter.text = min.ToString("00") + ":" + sec.ToString("00");

        }

       
      

        if (min >= 1f)
        {
            goback.SetActive(true);
            acaba = true;

            if (acaba == true)
            {
                Time.timeScale = 0.0f;
                goback.SetActive(true);

            }
        }
        else
        {
            StartCoroutine(Timer());
        }
    }

   public void gobaack()
   {
        acaba = false;
        min = 0f;
        sec = 0f;
        goback.SetActive(false);

        SceneManager.LoadScene(0);

       
    }
    public void retrytut()
    {
        acaba = false;
        goback.SetActive(false);
  
        SceneManager.LoadScene(1);
    }
    public void retry1()
    {
        acaba = false;
        goback.SetActive(false);
        SceneManager.LoadScene("lvl1");
    }
    public void retry2()
    {
        acaba = false;
        goback.SetActive(false);
        SceneManager.LoadScene("lvl2");
    }

}
