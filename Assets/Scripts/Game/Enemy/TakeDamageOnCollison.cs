using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnCollison : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemyHealth;
    private Bullet _bullet;
    private int Damage;


    private void OnTriggerEnter2D(Collider2D collision)//если в противника попадает пуля, ему наностится урон, а пуля исчезает
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
