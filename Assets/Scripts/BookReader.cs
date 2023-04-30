using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class BookReader : MonoBehaviour
{
    [SerializeField] private string bookFileName;

    private TextMeshProUGUI _text;
    private string fileName, bookFilePath;
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        
        fileName = bookFileName;
        bookFilePath = Application.dataPath + "/Books/" + bookFileName;
        
        List<string> fileLines = File.ReadAllLines(bookFilePath).ToList();
        foreach (string line in fileLines)
        {
            _text.text += line;
        }
    }
}
