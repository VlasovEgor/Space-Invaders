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
        _timer += Time.deltaTime; //������ ��������� ����� �������� ���� ����������� �� ������� ����
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
            if (_spawnEnemy.EnemyList[i]!=null) //�������� �� null ���������� �� ������� �������� �����
            {                                    //��� ���� ��������� �� �������� � � ����� ��� ���� �������������� ������� ����� ��� ����� ������ ��� �������� �������
                _spawnEnemy.EnemyList[i].GetComponent<MoveEnemy>().MovingToDownSide();
            }
            
        }
        _spawnEnemy.Spawn();
    }
}
