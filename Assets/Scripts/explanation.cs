using UnityEngine;

public class explanation : MonoBehaviour
{
    public GameObject instructionPanel; // 操作説明用パネル

    public MonoBehaviour[] scriptsToPause; // プレイヤー等の操作を一時停止したいスクリプト

    void Start()
    {
        ShowInstructions(); // ゲーム開始時に表示
    }

    public void ShowInstructions()
    {
        instructionPanel.SetActive(true);
        Time.timeScale = 0f;

        foreach (var script in scriptsToPause)
        {
            script.enabled = false;
        }
    }

    public void HideInstructions()
    {
        instructionPanel.SetActive(false);
        Time.timeScale = 1f;

        foreach (var script in scriptsToPause)
        {
            script.enabled = true;
        }
    }
}
