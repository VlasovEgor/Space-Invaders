using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageEnemy : MonoBehaviour
{
    [SerializeField] private int DamageValue=1;


    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.rigidbody) //���� ��������� ��� ��� ���� ������������ � rigidbody � ���� rigidbody ���������� � ���������
        {                       //������� ���� ��������� � ���������� ������
            if (collision.rigidbody.GetComponent<PlayerHealth>())
            {
                collision.rigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
                Destroy(gameObject);
            }
        }
       
    }
}
