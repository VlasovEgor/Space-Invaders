using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private float _timer;
    void Update()
    {
        _timer += Time.deltaTime; //запускаем таймер и спустя 3 секунды меняем сцену
        if(_timer>=3.0)
        {
            GoToMenu();
        }
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
