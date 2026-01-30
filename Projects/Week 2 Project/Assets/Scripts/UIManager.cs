using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public static UIManager S;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        S = this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int pointValue)
    {

        score += pointValue;

        scoreText.text = "Score :" + score;

    }
}
