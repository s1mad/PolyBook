using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class PageSwitcher : MonoBehaviour
{
    private TextMeshProUGUI _text;
    public int currentPage = 1, totalPage;
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        totalPage = _text.textInfo.pageCount;
    }

    public void nextPage()
    {
        if (currentPage < totalPage)
        {
            _text.pageToDisplay++;
            currentPage++;
        }
    }
    public void previousPage()
    {
        if (currentPage > 1)
        {   
            _text.pageToDisplay--;
            currentPage--;
        }
    }
}
