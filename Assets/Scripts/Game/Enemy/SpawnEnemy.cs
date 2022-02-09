using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public List<GameObject> EnemyList;
    [SerializeField] private GameObject enemyPrefab;
    private double _xPosition;
    private int _globalLvl=0;

    public void Spawn()
    {
        _globalLvl++;
        for (int i = 0; i < 6; i++) //������� 6 ����� �����������, ��������� �� � ������ � ��������� �������� �� ������� ����
        {
            _xPosition = -2 + 0.75 * i;
            GameObject newEnemy = Instantiate(enemyPrefab, new Vector3((float)_xPosition, 2, 0), Quaternion.identity);
            newEnemy.GetComponent<ShotEnemy>().LlvEnemy+= _globalLvl;
            EnemyList.Add(newEnemy);
        }

    }
}
