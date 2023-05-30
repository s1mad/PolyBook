using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaderMaskotTraining : MonoBehaviour
{
    [SerializeField] private GameObject _maskotTraining;
    [SerializeField] private GameObject _text1;
    [SerializeField] private GameObject _text2;
    [SerializeField] private FadeToScript fadeToScript;
    private int _selectedText = 1;

    public void MaskotTraining()
    {
        _selectedText++;
        switch (_selectedText)
        {
            case 2:
                _text2.SetActive(true);
                _text1.SetActive(false);
                break;
            default:
                fadeToScript.StartFade();
                break;
        }
    }
}
