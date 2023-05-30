using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeToScript : MonoBehaviour
{
    public GameObject[] gameObjects;
    public float fadeDuration = 0.5f;
    public float targetAlpha = 0f;
    public void StartFade()
    {
        foreach (GameObject go in gameObjects)
        {
            Image image = go.GetComponent<Image>();
            if (image != null)
            {
                StartCoroutine(FadeTo(image, targetAlpha, go));
            }
            else
            {
                StartCoroutine(FadeTo(go.GetComponent<TextMeshProUGUI>(), targetAlpha, go, fadeDuration));
            }
        }
    }

    private IEnumerator FadeTo(Image image, float targetAlpha, GameObject go)
    {
        float startAlpha = image.color.a;

        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);

            Color newColor = image.color;
            newColor.a = newAlpha;
            image.color = newColor;

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        Color finalColor = image.color;
        finalColor.a = targetAlpha;
        image.color = finalColor;
        
        go.SetActive(false);
    }

    private IEnumerator FadeTo(TextMeshProUGUI textMeshPro, float targetAlpha, GameObject go, float fadeDuration)
    {
        float startAlpha = textMeshPro.alpha;

        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);

            Color newColor = textMeshPro.color;
            newColor.a = newAlpha;
            textMeshPro.color = newColor;

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        Color finalColor = textMeshPro.color;
        finalColor.a = targetAlpha;
        textMeshPro.color = finalColor;

        go.SetActive(false);
    }

}
