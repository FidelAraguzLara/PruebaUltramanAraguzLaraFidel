using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardHover : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    public AudioSource soundEffect;
    public GameObject leftHoverText;
    public GameObject rightHoverText;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            leftHoverText.SetActive(true);
            rightHoverText.SetActive(false);
            soundEffect.Play();
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            rightHoverText.SetActive(true);   
            leftHoverText.SetActive(false);
            soundEffect.Play();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rightHoverText.SetActive(false);
        leftHoverText.SetActive(false);
    }
}


