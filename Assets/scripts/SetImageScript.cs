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
        // ���������� ��� ������
        foreach (Button button in buttons)
        {
            // �������� ��������� Image ������
            Image buttonImage = button.GetComponent<Image>();

            // ��������� ���������� ������� ������� �� ������
            button.onClick.AddListener(() => SetImage(buttonImage.sprite));
        }
    }

    private void SetImage(Sprite sprite)
    {
        // ���� ������ ��� ��������� ����������� � ��������� Image ����������
        if (targetObject != null && targetImage != null)
        {
            // ������������� ���������� ����������� �� ������� ������
            targetImage.sprite = sprite;
        }
    }
}

