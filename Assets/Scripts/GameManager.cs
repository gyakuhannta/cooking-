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
    [SerializeField]
    private Text Text1, Text2, Text3, Text4, Text5, Text6;

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
