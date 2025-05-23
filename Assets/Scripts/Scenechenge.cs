using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechenge : MonoBehaviour
{
    // シーンを切り替えるメソッド
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }    
}
