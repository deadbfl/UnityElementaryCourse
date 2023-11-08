using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndManager : MonoBehaviour
{
    public static GameEndManager instance;

    [SerializeField] private GameObject endPanel;
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void GameIsOver()
    {
        Cursor.lockState = CursorLockMode.None;
        endPanel.SetActive(true);
        scoreText.SetText("Score : " + ScoreManager.instance.score);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
