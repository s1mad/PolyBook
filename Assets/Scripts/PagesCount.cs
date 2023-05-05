using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PagesCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bookText;
    public GameObject  textObject;
    private TextMeshProUGUI counter;
    private void Start()
    {
        counter = textObject.GetComponent<TextMeshProUGUI>();
    }
    private void Update() 
    {
        counter.text = bookText.pageToDisplay + "/" + bookText.textInfo.pageCount;
    }
}
