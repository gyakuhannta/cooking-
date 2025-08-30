using UnityEngine;

public class yobidasi : MonoBehaviour
{

    public GameObject risp_1 ;//レシピ1のゲームオブジェクト
    public GameObject risp_2;//レシピ２のオブジェクト
    public GameObject risp_3;

    [SerializeField]
    public int Red;//レシピコード

    void Start()
    {
        switch(Red)
        {

            case 0://レシピがカレーの時にレシピ1のオブジェクトを有効にする
                risp_1.SetActive(true);
                risp_2.SetActive(false);
                risp_3.SetActive(false);
               
                break;

            case 1://レシピ２
                risp_1.SetActive(false);
                risp_2.SetActive(true);
                risp_3.SetActive(false);
                break ;
            case 2://レシピ３
                risp_1.SetActive(false);
                risp_2.SetActive(false);
                risp_3.SetActive(true);
                break ;
        }
    }

}
