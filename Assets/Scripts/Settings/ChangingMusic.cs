using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMusic : MonoBehaviour
{
    public void SetMusicEnabled(bool value) //включаем выключаем музыку
    {
        AudioSettings.Inctance.SetMusicEnabled(value);
    }
}
