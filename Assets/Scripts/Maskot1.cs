using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maskot1 : MonoBehaviour
{
    [SerializeField] private GameObject _text;
    void Start()
    {
        StartCoroutine(SetActiveText());
    }
    private IEnumerator SetActiveText()
    {
        yield return new WaitForSeconds(1f);
        _text.SetActive(true);
    }
}
