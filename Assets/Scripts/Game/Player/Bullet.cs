using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbodyBullet;
    [SerializeField] private float _speed;
    [SerializeField] private float _timeToDestroy = 4;
    private float _timer;
    public int BulletDamage;

    private void Start()
    {
        _rigidbodyBullet.velocity = Vector2.up * _speed;//выпускаем с определенной силой снаряд из кораблся
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _timeToDestroy)
        {
            DestroyingBullet(); //уничтожаем пулю через некоторое время, чтоб она не летела вечно за экраном
            _timer = 0;  //или если мы будем стрелять другим снарядом имели возможность изменять время жизни этого снаряда
        }
    }
    public void DestroyingBullet()
    {
        Destroy(gameObject);
    }
}