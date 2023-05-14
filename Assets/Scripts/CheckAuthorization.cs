using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckAuthorization : MonoBehaviour
{
    [SerializeField] GameObject authorizationPanel, loginPanel, restorePasswordPanel, RegistrationPanel, ChoiceLoginOrRegistrarion, ButtonBack;
    [SerializeField] TMP_InputField[] inputField;
    [SerializeField] TMP_InputField[] passwordInputField;

    public void CheckInputFieldClick()
    {
        if (inputField.Length == 1 && !string.IsNullOrEmpty(inputField[0].text))
        {
            restorePasswordPanel.SetActive(false);
            loginPanel.SetActive(true);
            return;
        }
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
            authorizationPanel.SetActive(false);
            loginPanel.SetActive(false);
            restorePasswordPanel.SetActive(false);
            RegistrationPanel.SetActive(false);
            ButtonBack.SetActive(false);
            ChoiceLoginOrRegistrarion.SetActive(true);
            foreach (TMP_InputField inputField in inputField)
                inputField.text = "";
        }
    }

    private bool CheckPasswordClick()
    {
        if (passwordInputField.Length == 2 && passwordInputField[0].text != passwordInputField[1].text)
            return false;
        return true;
    }

}