using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    [SerializeField] private GameObject _background;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _menuButton;
    public void CloseMenu()//отключаем все не нужное, включаем все нужное и запускаем время
    {
        _background.SetActive(false);
        _menu.SetActive(false);
        _menuButton.SetActive(true);
        Time.timeScale = 1;
    }
    
}
