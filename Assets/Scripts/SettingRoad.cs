using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingRoad : MonoBehaviour
{
    public void OpenSettingsScene()
    {
        // 今のシーン名を保存
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
        PlayerPrefs.Save();

        // 設定シーンをロード
        SceneManager.LoadScene("SettingScene");
    }
}
