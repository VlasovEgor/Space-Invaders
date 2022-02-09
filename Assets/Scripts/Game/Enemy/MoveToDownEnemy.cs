using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDownEnemy : MonoBehaviour
{
    [SerializeField] private SpawnEnemy _spawnEnemy;
    [SerializeField] private float _descentTime;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime; //спустя некоторое время опускаем всех противников на уровень ниже
        if(_timer>= _descentTime)
        {
            _timer = 0;
            MovingDOwnListEnemys();
        }
    }
    
    private void MovingDOwnListEnemys()
    {
        
        for (int i = 0; i < _spawnEnemy.EnemyList.Count; i++)
        {   
            if (_spawnEnemy.EnemyList[i]!=null) //проверка на null компрамисс на который пришлось пойти
            {                                    //без него нормально не работало и я решил что одно дополнительное условие лучше чем долго сидеть над решением пробемы
                _spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>().MovingToDownSide();
            }
            
        }
        _spawnEnemy.Spawn();
    }
}
