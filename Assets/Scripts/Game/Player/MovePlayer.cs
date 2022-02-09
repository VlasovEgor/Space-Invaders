using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        TouchTest();
    }
    private void TouchTest() //фиксируем нажатие на экран
    {
        if (Input.touchCount > 0)
        {
            MovementInCertainDirection();
        }
    }
    private void MovementInCertainDirection() //двигаемся в сторону нажатия
    {
        Touch touch = Input.GetTouch(0);
        if (touch.position.x > Screen.width / 2 &&gameObject.transform.position.x<2.5f)
        {
            transform.Translate(_speed*Time.deltaTime, 0, 0);
        }
        else if(gameObject.transform.position.x > -2.5f)
        {
            transform.Translate(-_speed*Time.deltaTime, 0, 0);
        }
    }
}