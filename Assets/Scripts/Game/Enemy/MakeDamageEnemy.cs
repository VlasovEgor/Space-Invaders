using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageEnemy : MonoBehaviour
{
    [SerializeField] private int DamageValue=1;


    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(collision.rigidbody) //если противник или его пуля пересекается с rigidbody и этот rigidbody отнносится к персонажу
        {                       //наносим урон персонажу и уничтожаем объект
            if (collision.rigidbody.GetComponent<PlayerHealth>())
            {
                collision.rigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
                Destroy(gameObject);
            }
        }
       
    }
}
