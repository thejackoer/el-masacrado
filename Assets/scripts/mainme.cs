using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mainme : MonoBehaviour
{
    public GameObject load;
    public GameObject mainn;
    public GameObject credit;
    public GameObject startt;
    public Canvas canvas;

    AsyncOperation async;

    public void Loadlevel(string lv)
    {
        StartCoroutine(loadingscreen(lv));

    }

    public void credito()
    {
        mainn.SetActive(false);
        credit.SetActive(true);
        startt.SetActive(false);

    }
    public void start()
    {
        mainn.SetActive(false);
        credit.SetActive(false);
        startt.SetActive(true);

    }
    public void maimenu()
    {
        mainn.SetActive(true);
        credit.SetActive(false);
        startt.SetActive(false);

    }


    IEnumerator loadingscreen(string lvl)
    {
        Time.timeScale = 1.0f;
        startt.SetActive(false);
        load.SetActive(true);
        async = SceneManager.LoadSceneAsync(lvl);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {

            if (async.progress == 0.9f)
            {
                load.SetActive(false);
                mainn.SetActive(true);
                async.allowSceneActivation = true;

            }
            yield return new WaitForSeconds(3);
        }


    }

}
