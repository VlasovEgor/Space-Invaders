using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnCollison : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemyHealth;
    private Bullet _bullet;
    private int Damage;


    private void OnTriggerEnter2D(Collider2D collision)//���� � ���������� �������� ����, ��� ���������� ����, � ���� ��������
    {   
        if(collision.GetComponent<Bullet>())
        {
            _bullet = collision.GetComponent<Bullet>();
            DealingDamage();
        }
    }
    private void DealingDamage()
    {
        
        Damage = _bullet.BulletDamage;
        _enemyHealth.TakeDamage(Damage);
        _bullet.DestroyingBullet();
    }
}
