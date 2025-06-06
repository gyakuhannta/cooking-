using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public TextMeshProUGUI scoreText;
<<<<<<< HEAD
    public GameObject panel;
    [SerializeField]
    private Text Text1, Text2, Text3, Text4, Text5, Text6;
=======
>>>>>>> origin/main

    void Awake()
    {
        Instance = this;   
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score : " + score;
        }
    }
<<<<<<< HEAD
=======
    
>>>>>>> origin/main
}
