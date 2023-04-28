using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class BookReader : MonoBehaviour
{
    public Transform contentWindow;
    public GameObject recallTextObject;
    void Start()
    {
        string readFromFilePath = Application.streamingAssetsPath + "/Books" + "idiot" + ".txt";
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();
        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.GetComponent<Text>().text = line;
        }
    }
}
