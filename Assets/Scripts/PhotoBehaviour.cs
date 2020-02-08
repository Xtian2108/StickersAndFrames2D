using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NatCamU.Core;
using NatCamU.Core.UI;
using TMPro;
public class PhotoBehaviour : MonoBehaviour
{

    public Texture2D photo;
    public NatCamPreview panel;
    public PantallasControl pC;

    private bool conteo;
    public float timerFoto = 3;
    public TextMeshProUGUI timerTexto;

    // Use this for initialization
    void Start()
    {
        timerTexto.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (conteo)
        {
            timerFoto -= Time.deltaTime;
            timerTexto.text = Mathf.RoundToInt(timerFoto).ToString();
            if(timerFoto <= 0)
            {
                NatCam.CapturePhoto(OnPhoto);
                pC.BotonTomarFoto();
                timerFoto = 3;
                conteo = false;
            }
        }
        else
        {
            timerTexto.text = "";
        }
    }

    public void OnPhotoCapture()
    {
        conteo = true;
    }

    void OnPhoto(Texture2D photo, Orientation orientation)
    {
        // Cache the photo
        this.photo = photo;
        //// Display the photo
        panel.Apply(photo, orientation);
        //// Enable the check icon
        //checkIco.gameObject.SetActive(true);
        //// Disable the switch camera button
        //switchCamButton.gameObject.SetActive(false);
        //// Disable the flash button
        //flashButton.gameObject.SetActive(false);
    }

    public void ActivarCamara()
    {
        Texture2D.Destroy(this.photo);
        panel.Apply(NatCam.Preview);
    }

}
