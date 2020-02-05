using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LastPhoto : MonoBehaviour
{

    public PhotoBehaviour photoB;
        
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarUltimaFoto()
    {
        GetComponent<RawImage>().texture = photoB.photo;
    }
}
