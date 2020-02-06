using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarcosBehaviour : MonoBehaviour {

    public Button[] botonesMarcos;
    public GameObject[] imagenesMarcos;
    public Button[] botonesStickers;
    public GameObject[] imagenesStickers;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BotonMarco()
    {
        ActivarBotones();
        DesactivarImagenesMarcos();
        botonesMarcos[0].interactable = false;
        imagenesMarcos[0].SetActive(true);
    }
    public void BotonMarco2()
    {
        ActivarBotones();
        DesactivarImagenesMarcos();
        botonesMarcos[1].interactable = false;
        imagenesMarcos[1].SetActive(true);
    }
    public void BotonMarco3()
    {
        ActivarBotones();
        DesactivarImagenesMarcos();
        botonesMarcos[2].interactable = false;
        imagenesMarcos[2].SetActive(true);
    }
    public void BotonMarco4()
    {
        ActivarBotones();
        DesactivarImagenesMarcos();
        botonesMarcos[3].interactable = false;
        imagenesMarcos[3].SetActive(true);
    }

    public void BotonStickers(int indice)
    {
        Color gris = new Color(1, 1, 1, 0.5019608f);
        Color blanco = new Color(1,1,1,1);
        if (botonesStickers[indice].image.color != gris)
        {
            botonesStickers[indice].image.color = gris;
            imagenesStickers[indice].SetActive(true);
        }
        else
        {
            botonesStickers[indice].image.color = blanco;
            imagenesStickers[indice].SetActive(false);
        }
    }

    public void ActivarBotones()
    {
        for (int i = 0; i < botonesMarcos.Length; i++)
        {
            botonesMarcos[i].interactable = true;
        }
    }

    public void DesactivarImagenesMarcos()
    {
        for (int i = 0; i < imagenesMarcos.Length; i++)
        {
            imagenesMarcos[i].SetActive(false);
        }
    }

}
