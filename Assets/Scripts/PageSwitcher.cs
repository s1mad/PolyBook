using System;
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
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable() => BookReader.getPages += SetTotalPages;

    private void OnDisable() => BookReader.getPages -= SetTotalPages;

    private void SetTotalPages(int pageCount)
    {
        totalPage = pageCount;
    }

    public void nextPage()
    {
        if (currentPage >= totalPage) return;
        _text.pageToDisplay++;
        currentPage++;
    }
    public void previousPage()
    {
        if (currentPage <= 1) return;
        _text.pageToDisplay--;
        currentPage--;
    }
}
