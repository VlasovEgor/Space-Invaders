using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : MonoBehaviour
{
    public int LlvEnemy;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private int TimeShot;
    private float _timer;
    private int _probabilityShot;
    private void Update()
    {
        _timer += Time.deltaTime;//стреляем через равные промежутки времени
        if (_timer >= TimeShot)
        {
            _timer = 0;
            Shot();
        }
    }
    private void Shot()
    {
        _probabilityShot = Random.Range(1, 100);//с некоторой вероятностью противник выстеливает в персонажа
        if (_probabilityShot <= LlvEnemy * 5)
        {
            Instantiate(BulletPrefab, transform);
        }
    }
}
