using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // デフォルトは0
        scoreText.text = "SCORE: " + finalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
