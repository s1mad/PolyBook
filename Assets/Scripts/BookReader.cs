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

        StartCoroutine(LoadBook());

        //bookFilePath = Application.streamingAssetsPath + "/" + bookFileName;
        
        textName.text = _name;
    }

    private void Update()
    {
        getPages?.Invoke(_text.textInfo.pageCount);
        if(_text.textInfo.pageCount > 0)
            Destroy(this);
    }
    
    IEnumerator LoadBook()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, bookFileName);
        if (filePath.Contains("://"))
        {
            //Android || iOS
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.SendWebRequest();
            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.LogError("Error while downloading book: " + www.error);
                yield break;
            }
            byte[] bytes = www.downloadHandler.data;
            
            string allText = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length);

            _text.SetText(allText);
        }
        else
        {
            //PC
            string[] fileLines = File.ReadAllLines(filePath);
            string allText = string.Join("", fileLines);
            
            _text.SetText(allText);
        }
    }
}
