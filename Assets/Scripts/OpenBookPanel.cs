using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBookPanel : MonoBehaviour
{
    [SerializeField] GameObject currentPanel, activePanel;
    public void CardBookCLick()
    {
        currentPanel.SetActive(false);
        activePanel.SetActive(true);
    }
}
