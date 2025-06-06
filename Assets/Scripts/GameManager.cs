using TMPro;
using UnityEngine;
using Unity;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject panel;

    void Awake()
    {
        Instance = this;   
    }
    void Start()
    {
        panel.SetActive(false);
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

    

}
