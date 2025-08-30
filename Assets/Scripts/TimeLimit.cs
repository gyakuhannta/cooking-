using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    public float timeLimit = 30f; //時間制限
    public TextMeshProUGUI timerText;
    public GameObject panel;

    private bool isTimeUp = false; // 時間切れになったかどうか
    private float timeUpTimer = 0f; // 時間切れ後の経過時間

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       //パネルオフ
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeUp)
        {
            timeUpTimer += Time.unscaledDeltaTime;

            // 3秒経過 or 左クリックでシーン再読み込み
            if (timeUpTimer >= 3f || Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1f; // 念のためゲームスピードを戻す
                SceneManager.LoadScene("ResultScene");
            }

            return; // 以下の処理は行わない
        }
        timeLimit -= Time.deltaTime;

        //残り時間を更新
        if (timerText != null)
        {
            timerText.text = "TIME LIMIT : " + Mathf.Ceil(timeLimit).ToString();
        }

        //時間切れ処理
        if (timeLimit <= 0f)
        {
            panel.SetActive(true);
            Time.timeScale = 0f; // ゲーム全体を停止
            isTimeUp = true;
        }
    }
}

