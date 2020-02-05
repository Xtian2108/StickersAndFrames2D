using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;

public class PantallasControl : MonoBehaviour {


    public GameObject[] pantallas;
    public GameObject tomarFoto;
    public GameObject volver;
    public GameObject ok;
    public PhotoBehaviour pB;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoverPantalla1()
    {
        pantallas[0].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
    }

    public void MoverPantalla2()
    {
        pantallas[1].GetComponent<DG.Tweening.DOTweenAnimation>().DOPlay();
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
