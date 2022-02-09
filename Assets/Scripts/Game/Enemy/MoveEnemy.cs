using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _leftBorderScreen = -2.4f; //��� ��� ���������� ������� ������ ��� � Screen ��� ��������� �� ��������
    [SerializeField] private float _rightBorderScreen = 2.4f;  //��� ���������� �� ��������� ����� ����������� ���� ��� ������ ���������� ��� ��������
    [SerializeField] private float _moveSpeed = 0.5f;
    [SerializeField] private float StepMoving = 1;
    [SerializeField] private float StepDown = 0.75f;
    private float _timer = 0;
    private Enemy _enemy;
    public bool _movementToRight = false; //������� ���������� ���������� �� ����������� �������� ������

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
        _timer += Time.deltaTime; //������ ����� �� ����� ����� �������� ����� ��� ������
        if (_timer >= _moveSpeed)
        {
            Move();
            _timer = 0;
        }

    }
    private void Move()
    {
        if (_movementToRight == false)
        {
            MovingToLeftSide();
        }
        else
        {
            MovingToRideSide();
        }
    }
    private void MovingToLeftSide()
    {

        if (transform.position.x > _leftBorderScreen)
        {
            transform.Translate(-StepMoving, 0, 0);
        }
        else
        {
            _enemy.SendingRequestForChangeMovements(); //������ �� ����� ��������
        }
    }

    private void MovingToRideSide()
    {

        if (transform.position.x < _rightBorderScreen)
        { 
            transform.Translate(StepMoving, 0, 0);
        }
        else
        {
            _enemy.SendingRequestForChangeMovements();
        }
    }

    public void MovingToDownSide() //����� �� ������� ����
    {
       transform.Translate(0, -StepDown, 0);
    }

}
