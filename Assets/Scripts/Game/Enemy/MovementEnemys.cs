using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemys : MonoBehaviour
{
    private GameObject _enemyController;
    private SpawnEnemy _spawnEnemy;
    void Start()
    {
        _enemyController = FindObjectOfType<SpawnEnemy>().gameObject;
        _spawnEnemy = _enemyController.GetComponent<SpawnEnemy>();
    }

    public void ChangeMovementsEnemys()
    {
        for (int i = 0; i < _spawnEnemy.EnemyList.Count; i++)
        {   if(_spawnEnemy.EnemyList[i]!=null) //проверка на null компрамисс на который пришлось пойти
            {                                  //без него нормально не работало и я решил что одно дополнительное условие лучше чем долго сидеть над решением пробемы
                _spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>()._movementToRight = !_spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>()._movementToRight;
                //меняем тут булевую переменную на противоположное значение
            }
        }

    }
}
