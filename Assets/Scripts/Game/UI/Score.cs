using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _score;
    public int TotalScore;

    public void IncreaseScore() //прибавл€ем счет за каждого убитого и обновл€ем общий счЄт
    {
        TotalScore += _score;
        _scoreText.text = "—чет: " + TotalScore;
    }
}
