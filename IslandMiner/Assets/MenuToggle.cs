using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuToggle : MonoBehaviour
{
    public GameObject menuPanel;
    private bool isMenuVisible = false;

    void Start()
    {
        menuPanel.SetActive(isMenuVisible);
    }
    public void ToggleMenu()
    {
        isMenuVisible = !isMenuVisible;
        menuPanel.SetActive(isMenuVisible);
    }
}
