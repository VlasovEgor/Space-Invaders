using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLosePanel : MonoBehaviour
{
    [SerializeField] private GameObject _losepanel;
    [SerializeField] private Text _losescore;
    [SerializeField] private Score _score; 
    public void Lose() //��������� ��� �� ������, �������� ��� ������ � ������������� �����
    {
        Time.timeScale = 0.001f;
        _losepanel.SetActive(true);
        _losescore.text = "����� ����" + _score.TotalScore;
    }
}
