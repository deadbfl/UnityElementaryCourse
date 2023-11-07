using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score;
    [SerializeField] private TMP_Text scoreText;
    private void Awake()
    {
        instance = this;
    }

    public void ChangeScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
}
