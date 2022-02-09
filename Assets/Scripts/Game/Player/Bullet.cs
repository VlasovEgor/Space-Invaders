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
        _rigidbodyBullet.velocity = Vector2.up * _speed;//��������� � ������������ ����� ������ �� ��������
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _timeToDestroy)
        {
            DestroyingBullet(); //���������� ���� ����� ��������� �����, ���� ��� �� ������ ����� �� �������
            _timer = 0;  //��� ���� �� ����� �������� ������ �������� ����� ����������� �������� ����� ����� ����� �������
        }
    }
    public void DestroyingBullet()
    {
        Destroy(gameObject);
    }
}