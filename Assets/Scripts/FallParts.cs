using UnityEngine;

public class FallParts : MonoBehaviour
{
    //落ちてくるオブジェクトのPrefab
    public GameObject objectPrefab;
    //生成する間隔（秒）
    public float spawnIntervel = 1f;
    //落ちてくる位置の範囲（X軸）
    public float spawnRangeX = 10f;
    //落ちる速度
    public float fallSpeed = 5f;
    
    void Start()
    {
        //一定間隔でオブジェクトを生成する
        InvokeRepeating("SpawnObject", 0f, spawnIntervel);
    }

    //オブジェクトをランダムな位置で生成
    void SpawnObject()
    {
        //X軸方向のランダムな位置
        float randamX = Random.Range(-spawnRangeX, spawnRangeX);
        //生成位置
        Vector3 spawnPosition = new Vector3(randamX, transform.position.y, 0f);
        //オブジェクトを生成
        GameObject gameObject1 = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        GameObject newObject = gameObject1;
        //新しく生成されたオブジェクトに[FallDown]スクリプトを追加して落ちるようにする
        newObject.AddComponent<FallDown>().fallSpeed = fallSpeed;
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
    }
}

