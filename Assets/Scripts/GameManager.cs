using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private TMP_Text scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}