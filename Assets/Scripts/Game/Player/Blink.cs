using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRendererPlayer; //обращаемся рендереру спрайта нашего коробля
    public void StartBlink(int timeBLink)
    {
        StartCoroutine(BlinkEffect(timeBLink)); //запускаем корутину на определенное время

    }
    public IEnumerator BlinkEffect(int timeBLink)
    {
        for (float t = 0; t < timeBLink; t+=Time.deltaTime)//в течении некторого времени наш корабль мерцает от черного к красному по синусойде
        {
            _spriteRendererPlayer.color = new Color(Mathf.Sin(t*30)*0.5f+0.5f, 0, 0, 1);
            yield return null;
        }
        _spriteRendererPlayer.color = new Color(1, 1, 1, 1); //после мерцания возвращаем изначальный цвет
    }
}
