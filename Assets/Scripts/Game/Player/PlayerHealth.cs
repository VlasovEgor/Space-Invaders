using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    public int MaxHealth; //���������� ����������� ���� �� ���������� �������, ���� � ��� �� ���� ����������� �������� ����������
    public int TimeInvulnerable=3;
    [SerializeField] private HealthUI _healthUI;
    [SerializeField] private Blink _blink;
    [SerializeField] private OpenLosePanel _losePanel;
    private bool _invulnerable = false;
    void Start()
    {
        _healthUI.Setup(MaxHealth);
        _healthUI.DisplayHealth(Health);
    }

    public void TakeDamage(int damageValue)//����� �� �������, �������� ���� � �������� ������������ 
    {   
        if(_invulnerable==false)
        {
            Health -= damageValue;
            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
            _healthUI.DisplayHealth(Health);
            _invulnerable = true;
            _blink.StartBlink(TimeInvulnerable);
            Invoke("StopInvulnerable", TimeInvulnerable);//���������� ���������� ����� ��������� �����
        }
    }
    private void StopInvulnerable() 
    {
        _invulnerable = false;
    }
    private void Die()
    {
        _losePanel.Lose();
    }
}
