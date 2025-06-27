using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingOut : MonoBehaviour
{
    public void GoBack()
    {
        // 保存していたシーン名を取得
        string previousScene = PlayerPrefs.GetString("PreviousScene", "");

        if (!string.IsNullOrEmpty(previousScene))
        {
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            // 保存されていない場合のデフォルト（例：タイトルに戻るなど）
            SceneManager.LoadScene("TitleScene");
        }
    }
}
