using UnityEngine;
using UnityEngine.UI;

public class Player_next : MonoBehaviour
{
    // カウント用の変数（5種類のオブジェクト）
    private int countTypeA = 0;
    private int countTypeB = 0;
    private int countTypeC = 0;
    private int countTypeD = 0;
    private int countTypeE = 0;
    private int countTypeF = 0;

    // UI Text コンポーネント
    public Text countTextA;
    public Text countTextB;
    public Text countTextC;
    public Text countTextD;
    public Text countTextE;

    public int total;
    void Update()
    {
        if (Time.timeScale == 0f) return;  // ポーズ中なら何もしない
        // マウスカーソルの位置を3D空間のワールド座標に変換
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // 3Dレイキャストを使って、カーソル位置にあるオブジェクトを検出
        RaycastHit hit;

        // レイキャストが何かにヒットした場合
        if (Physics.Raycast(ray, out hit))
        {
            // オブジェクトがカーソルの下にあることが判定できた
            Debug.Log("Hit Object: " + hit.collider.gameObject.name);
            // オブジェクトのタグに基づいてカウントを増やす
            string objectTag = hit.collider.gameObject.tag;
            switch (objectTag)
            {
                case "syoku_1":
                    countTypeA++;
                  
                    break;
                case "syoku_2":
                    countTypeB++;
                     //UpdateCountText();
                    break;
                case "syoku_3":
                    countTypeC++;
                  //  UpdateCountText();
                    break;
                case "syoku_4":
                    countTypeD++;
                    // UpdateCountText();
                    break;
                case "syoku_5":
                    countTypeE++;
                    // UpdateCountText();
                    break;
                case "syoku_6":
                    countTypeF++;
                    // UpdateCountText();
                    break;
            }
            total = countTypeA + countTypeB + countTypeC + countTypeD + countTypeE + countTypeF;

            // オブジェクトを削除
            Destroy(hit.collider.gameObject);  
            UpdateCountText();
            SaveScore();
        }
    }

    // カウントをUIに反映するメソッド
 private void UpdateCountText()
    {
        countTextA.text = "SCORE: " + total;
      
    }
    public void SaveScore()
    {
        int totalScore =+ total;
        PlayerPrefs.SetInt("FinalScore", totalScore);
        PlayerPrefs.Save();
    }
}
