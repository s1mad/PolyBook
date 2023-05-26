using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Maskot : MonoBehaviour
{
    [SerializeField] private GameObject MaskotTraining;
    [SerializeField] private GameObject Scene1;
    [SerializeField] private GameObject Scene2;
    [SerializeField] private GameObject _choicePanel;
    [SerializeField] private GameObject _noPanel;
    [SerializeField] private GameObject _text;
    [SerializeField] private GameObject _buttonScene;
    [SerializeField] private Image _image;
    [SerializeField] private GameObject _text2;
    [SerializeField] private GameObject _text3;
    private float _fadeDuration = 1.5f;
    private float _targetAlpha = 0f;

    private Animator _animator;
    private Button _button;

    private int _selectedText = 1;


    public void Scene1_NoButton()
    {
        _choicePanel.SetActive(false);
        _noPanel.SetActive(true);
        StartCoroutine(FadeTo(_targetAlpha));
        StartCoroutine(SetActiveMaskotTraining());
    }
    public void Scene1_YesButton()
    {
        Animator _animator = GetComponent<Animator>();
        _button = _buttonScene.GetComponent<Button>();
        StartCoroutine(FadeTo(_targetAlpha));
        _choicePanel.SetActive(false);
        _animator.enabled = true;
        StartCoroutine(SetActiveText(_button));
    }
    private IEnumerator SetActiveText(Button _button)
    {
        yield return new WaitForSeconds(1.5f);
        _text.SetActive(true);
        _button.interactable = true;
    }

    private IEnumerator SetActiveMaskotTraining()
    {
        yield return new WaitForSeconds(3f);
        MaskotTraining.SetActive(false);
    }

    private IEnumerator FadeTo(float targetAlpha)
    {
        float startAlpha = _image.color.a;

        float elapsedTime = 0f;
        while (elapsedTime < _fadeDuration)
        {
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / _fadeDuration);

            Color newColor = _image.color;
            newColor.a = newAlpha;
            _image.color = newColor;

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        Color finalColor = _image.color;
        finalColor.a = targetAlpha;
        _image.color = finalColor;
    }

    public void ReplaceText()
    {
        _selectedText++;
        switch (_selectedText)
        {
            case 2:
                _text2.SetActive(true);
                _text.SetActive(false);
                break;
            case 3:
                _text3.SetActive(true);
                _text2.SetActive(false);
                break;
            default:
                Scene1.SetActive(false);
                Scene2.SetActive(true);
                break;
        }
    }
}
