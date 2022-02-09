using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioSource _music;

    public static AudioSettings Inctance;
    private void Awake()
    {
        if (Inctance == null) //��� � ��� ������� �������� ������� �������� �� �� ���� � ��� �� ���� ��������� ������������
        {                     //� ��� �� ��� ��� �� ������������ � ����
            Inctance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }

    }

    public void SetMusicEnabled(bool value) //� ���� ������ �� �������� ��������� ������
    {
         _music.enabled = value;
    }

}
