using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        // Unityエディターで動作確認する用（開発中はここが実行される）
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // ビルド後の実行ファイルではこちらが実行される
        Application.Quit();
#endif
    }
}
