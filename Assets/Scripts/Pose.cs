using UnityEngine;
using UnityEngine.UI;

public class Pose : MonoBehaviour
{
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //パネルオフ
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //ポーズ処理
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
            
        }
    }

    //パネル展開(ボタン用)
    public void ShowPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0f; // ゲーム全体を停止
    }
    //パネル収縮(ボタン用)
    public void HidePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1f; // 再開
    }
}
