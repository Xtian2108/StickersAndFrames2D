using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoverStickers : MonoBehaviour , IDragHandler
{
    private RectTransform rectTransform;
    private PantallasControl pc;


    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        pc = GameObject.Find("Pantallas").GetComponent<PantallasControl>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta * 1.25f;
        pc.ResetearTimer();
    }

}
