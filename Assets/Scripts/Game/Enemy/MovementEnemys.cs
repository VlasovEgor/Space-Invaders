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
        {   if(_spawnEnemy.EnemyList[i]!=null) //�������� �� null ���������� �� ������� �������� �����
            {                                  //��� ���� ��������� �� �������� � � ����� ��� ���� �������������� ������� ����� ��� ����� ������ ��� �������� �������
                _spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>()._movementToRight = !_spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>()._movementToRight;
                //������ ��� ������� ���������� �� ��������������� ��������
            }
        }

    }
}
