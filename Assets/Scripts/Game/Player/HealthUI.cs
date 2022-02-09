using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public List<GameObject> HealthIcons = new List<GameObject>();
    [SerializeField] private GameObject _heart;

    public void Setup(int health) //здесь мы с помощью префобов показываем количество жизней нашего персонажа
    {
        for (int i = 0; i < health; i++)
        {
            GameObject newIcon = Instantiate(_heart, transform);
            HealthIcons.Add(newIcon);
        }
    }
    public void DisplayHealth(int health) //если нам нанесли урон или мы похилились, тут мы обновляем информацию об этом
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
