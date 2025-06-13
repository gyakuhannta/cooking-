using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public TextMeshProUGUI scoreText;

    public GameObject panel;
    [SerializeField]
<<<<<<< HEAD
   
=======
    

>>>>>>> 1914b5d7963353849b93953c286afacfcef7f90f

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

>>>>>>> 1914b5d7963353849b93953c286afacfcef7f90f
}
