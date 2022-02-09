using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioSource _music;

    public static AudioSettings Inctance;
    private void Awake()
    {
        if (Inctance == null) //это у нас паттерн синглтон который отвечает за то чтоб у нас не было множества аудиодорожек
        {                     //и что бы все это не превратилось в кашу
            Inctance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }

    }

    public void SetMusicEnabled(bool value) //в этом методе мы включаем выключаем музыку
    {
         _music.enabled = value;
    }

}
