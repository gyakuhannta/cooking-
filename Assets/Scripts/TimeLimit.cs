using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    public float timeLimit = 30f; //ŠÔ§ŒÀ
    public TextMeshProUGUI timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        //c‚èŠÔ‚ğXV
        if (timerText != null)
        {
            timerText.text = "TIME LIMIT : " + Mathf.Ceil(timeLimit).ToString();
        }

        //ŠÔØ‚êˆ—
        if (timeLimit <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
;       }
    }
}
