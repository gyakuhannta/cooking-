using UnityEngine;
using UnityEngine.UI;

public class Prefab : MonoBehaviour
{
    [SerializeField]
   public Text Text1, Text2, Text3, Text4, Text5;
    private int count1, count2, count3, count4, count5 = 0;
    public int id; // Inspectorで設定する番号
    public int Rid　= 0;
    public void OnClickedByRay()
    {
        Debug.Log("Rayでクリックされた！");
        switch (Rid)//料理ID判定
        {
           case 0://ビーフカレー
                switch (id)//具罪ID判定
                {
                   case 1://じゃが
                        count1+= 1;
                        Text1.text = "ジャガイモ: " + count1.ToString();
                   
                        break;
                   case 2://人参
                        count2 += 1;
                        Text2.text = "にんじん: " + count2.ToString();
                       
                        break;
                   case 3://カレールー
                        count3 += 1;
                        Text3.text = "カレールー: " + count3.ToString();
                        
                        break;
                   case 4://玉ねぎ
                        count4 += 1;
                        Text4.text = "玉ねぎ: " + count4.ToString();
                       
                        break;
                   case 5://牛肉
                        count5 += 1;
                        Text5.text = "牛肉: " + count5.ToString();
                        
                        break;
                   case 6://豚肉
                   case 12://キャベツ
                        
                        break;
                   case 7://クリームソース
                       
                        break;
                   case 8://リンゴ
                       
                        break;
                   default://その他
                      
                        break;

                }
                break;
           case 1://シチュー
                switch (id)//具罪ID判定
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                    case 12:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
                break;
           case 2:
                switch (id)//具罪ID判定
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                    case 12:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
                break;
           case 3:
                switch (id)//具罪ID判定
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                    case 12:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
                break;
           case 4:
                switch (id)//具罪ID判定
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                    case 12:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
                break;
        }

        Destroy(this.gameObject);
    }

}
