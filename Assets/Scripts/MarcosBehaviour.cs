using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarcosBehaviour : MonoBehaviour {

    public Button[] botonesMarcos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BotonMarco()
    {
        ActivarBotones();
        botonesMarcos[0].interactable = false;
    }
    public void BotonMarco2()
    {
        ActivarBotones();
        botonesMarcos[1].interactable = false;
    }
    public void BotonMarco3()
    {
        ActivarBotones();
        botonesMarcos[2].interactable = false;
    }
    public void BotonMarco4()
    {
        ActivarBotones();
        botonesMarcos[3].interactable = false;
    }

    public void ActivarBotones()
    {
        for (int i = 0; i < botonesMarcos.Length; i++)
        {
            botonesMarcos[i].interactable = true;
        }
    }

}
