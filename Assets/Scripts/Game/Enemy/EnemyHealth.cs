using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    private Score _score;

    private void Start()
    {
        _score = FindObjectOfType<Score>();
    }
    public void TakeDamage(int damageValue)//�������� ����,��� ������ �������� ���������� ��������� 0, �� ������������
    {
        _health -= damageValue;
        if(_health<=0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
        _score.IncreaseScore();
    }
}
