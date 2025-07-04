using UnityEngine;
using UnityEngine.UIElements;

public class object_min : MonoBehaviour
{
    //落ちてくるゲームオブジェクト
    public GameObject siyoku_1;
    public GameObject siyoku_2;
    public GameObject siyoku_3;
    public GameObject siyoku_4;
    public GameObject siyoku_5;
    public GameObject siyoku_6;
    public GameObject siyoku_7;
    public GameObject siyoku_8;
    public GameObject siyoku_9;

    public float randm_x = 10f;//生成範囲
    public float follspid = 5f;//落下速度
    float[] item;
    public float _repeatSpan = 0.5f;    //繰り返す間隔
    private float _timeElapsed;   //経過時間

    private float rin;//抽選結果を渡す用


    //ローカル関数
    float Choose(float[] probs)
    {

        float total = 0;

        //配列の要素を代入して重みの計算
        foreach (float elem in probs)
        {
            total += elem;
        }

        //重みの総数に0から1.0の乱数をかけて抽選を行う
        float randomPoint = Random.value * total;

        //iが配列の最大要素数になるまで繰り返す
        for (int i = 0; i < probs.Length; i++)
        {
            //ランダムポイントが重みより小さいなら
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                //ランダムポイントが重みより大きいならその値を引いて次の要素へ
                randomPoint -= probs[i];
            }
        }

        //乱数が１の時、配列数の-１＝要素の最後の値をChoose配列に戻している
        return probs.Length - 1;
    }




    private void Start()
    {
            //実行間隔を1に設定
        _timeElapsed = 0;   //経過時間をリセット


    }

    private void FixedUpdate()
    {

        _timeElapsed += Time.deltaTime;     //時間をカウントする


        //経過時間が繰り返す間隔を経過したら
        if (_timeElapsed >= _repeatSpan)
        {


            item = new float[10];
            //抽選確率
            item[0] = 20;
            item[1] = 15;
            item[2] = 15;
            item[3] = 10;
            item[4] = 10;
            item[5] = 5;
            item[6] = 10;
            item[7] = 10;
            item[8] = 5;
            item[9] = 20;
            //抽選メソッドを呼ぶ
            var result = Choose(item);

            rin = result;
    
        //X軸方向のランダムな位置


        float randamX = Random.Range(-randm_x, randm_x);
        //生成位置
        Vector3 spawnPosition = new Vector3(randamX, transform.position.y, 0f);
        //オブジェクトを生成




        switch (rin)//item[]によって変わる
        {
            case 0://item[0]の場合

                Instantiate(siyoku_1, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                    //対応したオブジェクトを生成：fallDownを作ったオブジェクトに付与 

                    break;
            case 1:
                Instantiate(siyoku_2, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
               
                break;
            case 2:
                Instantiate(siyoku_3, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            case 3:
                Instantiate(siyoku_4, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;

                break;
            case 4:
                Instantiate(siyoku_5, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            case 5:
                Instantiate(siyoku_6, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            case 6:
                Instantiate(siyoku_7, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            case 7:
                Instantiate(siyoku_8, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            case 8:
                Instantiate(siyoku_9, spawnPosition, Quaternion.identity).AddComponent<FallDown>().fallSpeed = follspid;
                break;
            default:
                break;

        }


            _timeElapsed = 0;   //経過時間をリセットする

        }

    }
   


 
    public class FallDown : MonoBehaviour
    {
        //落ちる速度
        public float fallSpeed;

        //毎フレームオブジェクトを下に落とす
        void Update()
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

            // transformを取得
            Transform myTransform = this.transform;
            // ワールド座標を基準に、座標を取得
            Vector3 worldPos = myTransform.position;

            if ( worldPos.y== 50) 
            {
                

            }

        }





    }
}

