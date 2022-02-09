using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
    [SerializeField] private Transform _gunTransform;
    [SerializeField] private int _rechargeTime;
    [SerializeField] private GameObject _bulletPrefabs;
    [SerializeField] private AudioSource _gunShotSound;
    private float _timer = 0;

    private void Update() //� ������������ �������������� ������������ �� �������
    {
        _timer += Time.deltaTime;
        if (_timer >= _rechargeTime)
        {
            Shot();
            _timer = 0;
        }
    }

    private void Shot() //������������ � ������ ��� ���� ����������� ����
    {
        Instantiate(_bulletPrefabs, _gunTransform.position, Quaternion.identity);
        _gunShotSound.Play();
    }
}
