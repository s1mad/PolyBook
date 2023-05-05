using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using TMPro;

public class BookReader : MonoBehaviour
{
    [SerializeField] private string bookFileName;
    [SerializeField] public GameObject textNameObject;
    [SerializeField] public string _name;

    private TextMeshProUGUI textName;
    private TextMeshProUGUI _text;

    private string bookFilePath;

    public static Action<int> getPages;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        textName = textNameObject.GetComponent<TextMeshProUGUI>();

        bookFilePath = Application.dataPath + "/Books/" + bookFileName;
        
        var fileLines = File.ReadAllLines(bookFilePath).ToList();

        textName.text = _name;
        var allText = "";

        foreach (var line in fileLines)
        {
            allText += line;
        }
        
        _text.SetText(allText);
    }

    private void Update()
    {
        getPages?.Invoke(_text.textInfo.pageCount);
        if(_text.textInfo.pageCount > 0)
            Destroy(this);
    }
}
