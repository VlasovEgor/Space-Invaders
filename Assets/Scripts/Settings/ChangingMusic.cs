using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMusic : MonoBehaviour
{
    public void SetMusicEnabled(bool value) //�������� ��������� ������
    {
        AudioSettings.Inctance.SetMusicEnabled(value);
    }
}
