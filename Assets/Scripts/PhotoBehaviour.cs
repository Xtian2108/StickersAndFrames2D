using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NatCamU.Core;
using NatCamU.Core.UI;

public class PhotoBehaviour : MonoBehaviour
{

    public Texture2D photo;
    public NatCamPreview panel;
    public PantallasControl pC;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPhotoCapture()
    {
        NatCam.CapturePhoto(OnPhoto);
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
