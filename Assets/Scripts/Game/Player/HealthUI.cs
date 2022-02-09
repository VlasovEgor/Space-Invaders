using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public List<GameObject> HealthIcons = new List<GameObject>();
    [SerializeField] private GameObject _heart;

    public void Setup(int health) //����� �� � ������� �������� ���������� ���������� ������ ������ ���������
    {
        for (int i = 0; i < health; i++)
        {
            GameObject newIcon = Instantiate(_heart, transform);
            HealthIcons.Add(newIcon);
        }
    }
    public void DisplayHealth(int health) //���� ��� ������� ���� ��� �� ����������, ��� �� ��������� ���������� �� ����
    {
        for (int i = 0; i < HealthIcons.Count; i++)
        {
            if (i < health)
            {
                HealthIcons[i].SetActive(true);
            }
            else
            {
                HealthIcons[i].SetActive(false);
            }
        }
    }
}
