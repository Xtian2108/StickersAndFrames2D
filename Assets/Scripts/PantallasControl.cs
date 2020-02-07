using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallasControl : MonoBehaviour {


    public GameObject[] pantallas;
    public GameObject tomarFoto;
    public GameObject volver;
    public GameObject ok;
    public PhotoBehaviour pB;
    public ScreenshotHandler ssh;
    public float timer;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (!Input.anyKey)
        {
            timer += Time.deltaTime;
            if(timer >= 30f)
            {
                VolverInicio();
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }	
	}

    public void MoverPantalla1()
    {
        pantallas[0].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void MoverPantalla2()
    {
        pantallas[1].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void MoverPantalla3()
    {
        ssh.TakeHiResShotFrame();
        pantallas[2].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void MoverPantalla4()
    {
        ssh.TakeHiResShotStickers();
        pantallas[3].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void MoverPantalla5()
    {
        pantallas[4].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void VolverInicio()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BotonTomarFoto()
    {
        volver.SetActive(true);
        ok.SetActive(true);
        tomarFoto.SetActive(false);
    }

    public void BotonVolver()
    {
        pB.ActivarCamara();
        volver.SetActive(false);
        ok.SetActive(false);
        tomarFoto.SetActive(true);
    }

}
