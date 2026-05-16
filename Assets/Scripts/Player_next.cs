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


    public GameObject dan_1;
    public GameObject dan_2;
    public GameObject dan_3;
    public GameObject dan_4;
    public GameObject dan_5;
    public GameObject dan_6;
    
    
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
            Vector3 ber = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            // オブジェクトがカーソルの下にあることが判定できた
            Debug.Log("Hit Object: " + hit.collider.gameObject.name);

            // オブジェクトのタグに基づいてカウントを増やす
            string objectTag = hit.collider.gameObject.tag;

            switch (objectTag)
            {
                case "syoku_1":
                    countTypeA++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_1,ber,Quaternion.identity).AddComponent<Rigidbody>();
                  
                    break;
                case "syoku_2":
                    countTypeB++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_2, ber, Quaternion.identity).AddComponent<Rigidbody>();
                     //UpdateCountText();
                    break;
                case "syoku_3":
                    countTypeC++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_3, ber, Quaternion.identity).AddComponent<Rigidbody>();
                  //  UpdateCountText();
                    break;
                case "syoku_4":
                    countTypeD++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_4, ber, Quaternion.identity).AddComponent<Rigidbody>();
                    // UpdateCountText();
                    break;
                case "syoku_5":
                    countTypeE++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_5, ber, Quaternion.identity).AddComponent<Rigidbody>();
                    // UpdateCountText();
                    break;
                /*case "syoku_6":
                    countTypeF++;
                    Destroy(hit.collider.gameObject);
                    Instantiate(dan_6, ber, Quaternion.identity).AddComponent<Rigidbody>();
                    // UpdateCountText();
                    break;*/
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
