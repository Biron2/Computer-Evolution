using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ClickTextFadeOut : MonoBehaviour
{
    private float fadeDuration = 2f;
    private float fadeTimer = 0f;
    private float yOffset = 0.5f;
    private Text numberText;

    void Start()
    {
        numberText = transform.Find("number").GetComponent<Text>();
        // Сохраняем начальную позицию объекта
        Vector3 initialPosition = transform.position;
        Vector3 targetPosition = initialPosition + new Vector3(0, yOffset, 0);
        StartCoroutine(MoveUpAndFadeOut(initialPosition, targetPosition));
    }

    private IEnumerator MoveUpAndFadeOut(Vector3 startPos, Vector3 targetPos)
    {
        float t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / fadeDuration;
            transform.position = Vector3.Lerp(startPos, targetPos, t);
            fadeTimer += Time.deltaTime;
            Color textColor = numberText.color;
            textColor.a = Mathf.Lerp(1f, 0f, fadeTimer / fadeDuration);
            numberText.color = textColor;
            yield return null;
        }

        // Уничтожаем объект
        Destroy(gameObject);
    }
}