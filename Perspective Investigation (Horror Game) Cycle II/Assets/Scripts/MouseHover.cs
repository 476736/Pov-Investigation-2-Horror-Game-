using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class MouseHover : MonoBehaviour, IPointerEnterHandler
{
    public Text NameOfGame;
    public Text Start;
    public Text Quit;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Start.color = Color.white;
        Quit.color = Color.white;
    }
}
