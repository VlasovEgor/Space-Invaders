using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRendererPlayer; //���������� ��������� ������� ������ �������
    public void StartBlink(int timeBLink)
    {
        StartCoroutine(BlinkEffect(timeBLink)); //��������� �������� �� ������������ �����

    }
    public IEnumerator BlinkEffect(int timeBLink)
    {
        for (float t = 0; t < timeBLink; t+=Time.deltaTime)//� ������� ��������� ������� ��� ������� ������� �� ������� � �������� �� ���������
        {
            _spriteRendererPlayer.color = new Color(Mathf.Sin(t*30)*0.5f+0.5f, 0, 0, 1);
            yield return null;
        }
        _spriteRendererPlayer.color = new Color(1, 1, 1, 1); //����� �������� ���������� ����������� ����
    }
}
