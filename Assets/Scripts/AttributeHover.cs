using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class AttributeHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hoverText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverText.SetActive(true);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverText.SetActive(false);
    }
}
