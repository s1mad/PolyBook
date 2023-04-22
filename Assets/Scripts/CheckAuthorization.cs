using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckAuthorization : MonoBehaviour
{
    [SerializeField] TMP_InputField[] inputField;
    [SerializeField] GameObject currentPanel, activePanel;
    [SerializeField] TMP_InputField[] passwordInputField;

    public void CheckInputFieldClick()
    {
        bool isFill = true;
        foreach (TMP_InputField inputField in inputField)
        {
            if (string.IsNullOrEmpty(inputField.text))
            {
                isFill = false;
                break;
            }
        }
        if (isFill && CheckPasswordClick())
        {
            currentPanel.SetActive(false);
            activePanel.SetActive(true);
        }
    }

    private bool CheckPasswordClick()
    {
        if (passwordInputField.Length == 2 && passwordInputField[0].text != passwordInputField[1].text)
            return false;
        return true;
    }

}