using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMovement : MonoBehaviour
{
    public Transform targetObject;  // Объект, к которому кнопка будет перемещаться
    public float speed = 1f;        // Скорость перемещения кнопки

    private Vector3 startPosition;  // Начальная позиция кнопки
    private Vector3 targetPosition;  // Целевая позиция кнопки
    private bool isMoving;          // Флаг для отслеживания состояния перемещения кнопки

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MoveButton);
        startPosition = transform.position;
        isMoving = false;
    }

    void MoveButton()
    {
        if (!isMoving)
        {
            targetPosition = targetObject.position;
            isMoving = true;
        }
    }

    void Update()
    {
        if (isMoving)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            // Проверяем, достигла ли кнопка целевой позиции
            if (transform.position == targetPosition)
            {
                isMoving = false;  // Завершаем перемещение кнопки

            }
        }
    }
}
