using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMovement : MonoBehaviour
{
    public Transform targetObject;  // ������, � �������� ������ ����� ������������
    public float speed = 1f;        // �������� ����������� ������

    private Vector3 startPosition;  // ��������� ������� ������
    private Vector3 targetPosition;  // ������� ������� ������
    private bool isMoving;          // ���� ��� ������������ ��������� ����������� ������

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

            // ���������, �������� �� ������ ������� �������
            if (transform.position == targetPosition)
            {
                isMoving = false;  // ��������� ����������� ������

            }
        }
    }
}
