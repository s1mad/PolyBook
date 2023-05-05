using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BookSlider : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bookText;
    private Slider _slider;
    private float sliderStep;
    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener((v) =>
        {
            bookText.pageToDisplay = (int)v;
        });
    }

    private void OnEnable() => BookReader.getPages += GetSliderStep;

    private void OnDisable() => BookReader.getPages -= GetSliderStep;

    private void GetSliderStep(int pageCount)
    {
        _slider.maxValue = pageCount;
    }
}
