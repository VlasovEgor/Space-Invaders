using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menuButton;
    [SerializeField] private GameObject _menu;
    public void Open() //отключаем все не нужное, включаем все нужное и останавливаем время
    {
        _menu.SetActive(true);
        _menuButton.SetActive(false);
        Time.timeScale = 0.001f;
    }
}
