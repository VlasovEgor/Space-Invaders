using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject _enemyController;
    private MovementEnemys _movementEnemys;
    
  
    private void Start()
    {
        _enemyController = FindObjectOfType<SpawnEnemy>().gameObject;
        _movementEnemys = _enemyController.GetComponent<MovementEnemys>();
    }

    public void SendingRequestForChangeMovements() //передаем запрос в контроллер противников о смене движения всех противников
    {
        _movementEnemys.ChangeMovementsEnemys();
    }
   
}
