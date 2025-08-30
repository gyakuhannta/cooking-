using UnityEngine;

public class praya : MonoBehaviour
{
    Vector3 pos;

    void Update()
    {
        //マウス座標取得
        pos = Input.mousePosition;
        //座標変換
        pos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 10f));
        //位置更新
        this.transform.position = pos;
        
      
       
    }

    


}
