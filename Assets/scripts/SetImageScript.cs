using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImageScript : MonoBehaviour
{
    public Button[] buttons;
    public GameObject targetObject;
    public Image targetImage;

    private void Start()
    {
        // Перебираем все кнопки
        foreach (Button button in buttons)
        {
            // Получаем компонент Image кнопки
            Image buttonImage = button.GetComponent<Image>();

            // Назначаем обработчик события нажатия на кнопку
            button.onClick.AddListener(() => SetImage(buttonImage.sprite));
        }
    }

    private void SetImage(Sprite sprite)
    {
        // Если объект для установки изображения и компонент Image существуют
        if (targetObject != null && targetImage != null)
        {
            // Устанавливаем переданное изображение на целевой объект
            targetImage.sprite = sprite;
        }
    }
}

