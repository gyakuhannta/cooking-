using UnityEngine;
using UnityEngine.UI;

public class Pose : MonoBehaviour
{
    public GameObject panel;
   
    public MonoBehaviour[] scriptsToPause;

    private bool isPaused = false;  // ポーズ状態を管理

    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                // ポーズ解除
                HidePanel();
            }
            else
            {
                // ポーズ開始
                ShowPanel();
            }
        }
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;

        foreach (var script in scriptsToPause)
        {
            script.enabled = false;
        }

        isPaused = true;
    }

    public void HidePanel()
    {
        panel.SetActive(false);

        foreach (var script in scriptsToPause)
        {
            script.enabled = true;
        }

        Time.timeScale = 1f;
        isPaused = false;
    }
}
