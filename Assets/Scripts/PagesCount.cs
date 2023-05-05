using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PagesCount : MonoBehaviour
{
    public GameObject scriptObject, textObject;
    private PageSwitcher pageSwitcher;
    private TextMeshProUGUI counter;
    void Start()
    {
        pageSwitcher = scriptObject.GetComponent<PageSwitcher>();
        counter = textObject.GetComponent<TextMeshProUGUI>();
    }
    void Update() 
    {
        counter.text = pageSwitcher.currentPage.ToString() + "/" + pageSwitcher.totalPage.ToString();
    }
}
