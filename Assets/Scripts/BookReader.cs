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
    [SerializeField] public GameObject textNameObject;
    [SerializeField] public string _name;

    private TextMeshProUGUI textName;
    private TextMeshProUGUI _text;
    private string fileName, bookFilePath;
    
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        textName = textNameObject.GetComponent<TextMeshProUGUI>();

        fileName = bookFileName;
        bookFilePath = Application.dataPath + "/Books/" + bookFileName;
        
        List<string> fileLines = File.ReadAllLines(bookFilePath).ToList();

        textName.text = _name;

        foreach (string line in fileLines)
        {
            _text.text += line;
        }
    }
}
