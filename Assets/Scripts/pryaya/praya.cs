using UnityEngine;

public class praya : MonoBehaviour
{
    Vector3 pos;

    void Update()
    {
        //マウス座標取得
        pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 10f));
        this.transform.position = pos;
        if (Input.GetMouseButtonDown(0))
        {



        }
    }




}
