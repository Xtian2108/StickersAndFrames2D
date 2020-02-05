using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetRenderTexture : MonoBehaviour {

    public RawImage camara;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<RawImage>().texture = camara.texture;
            Debug.Log(GetComponent<RawImage>().texture.name);
        }

    }
}
