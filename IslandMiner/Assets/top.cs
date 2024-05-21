using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class top : MonoBehaviour, IPointerClickHandler
{ 
    [SerializeField] Text countText; 
    int count;

    void Start() {
        countText.text = ""; 
    }

    
    public void OnPointerClick(PointerEventData eventData) 
    {
        count++; 
        countText.text = count + "回"; 
    }
}

