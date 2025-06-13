using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public enum WeaponType { Knife,Hummer,Sword,Axe,Blead}
    public enum dishType {Curry, stew,hotpot,sourpork,okonomiyaki}

    

    [Header("選択中の内容(自動設定)")]
　　public WeaponType selectedWeapon = WeaponType.Knife;
    public dishType selecteddish = dishType.Curry;
    [Header("メインシーン用")]
    public GameObject[] weaponPrefab;
    public GameObject[] dishPrefab;
    [Header("リザルト用")]
    public Image dishImage;
    public Sprite[] dishSprite;

    private const string WeaponKey = "selectedWeapon";
    private const string dishKey = "selecteddish";

    private void Awake()
    {
        // 選択情報が保存されていたら取得
        if (PlayerPrefs.HasKey(WeaponKey)) selectedWeapon = 
                (WeaponType)PlayerPrefs.GetInt(WeaponKey);
        if(PlayerPrefs.HasKey(dishKey)) selecteddish = 
                (dishType )PlayerPrefs.GetInt(dishKey);  

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string scene = SceneManager.GetActiveScene().name;

        if (scene == "MainScene")
        {
            SetupMainScene();
        }
        else if (scene =="ResultScene")
        {
            SetupResultScene();
        }
        else if (scene == "TitleScene")
        {
            ResetSelect();
        }
    }

    //武器ボタンに紐づけ
    public void selectWeapon(int index)
    {
        selectedWeapon　= (WeaponType)index;
        PlayerPrefs.SetInt(WeaponKey,index);
        PlayerPrefs.Save();
    }

    public void selectDish(int index)
    {
        selecteddish = (dishType)index;
        PlayerPrefs.SetInt(dishKey,index);
        PlayerPrefs.Save();
    }

    void SetupMainScene()
    {
        if(weaponPrefab.Length > 0)
        {
            for(int i = 0; i < weaponPrefab.Length; i++)
                weaponPrefab[i]?.SetActive(i == (int)selectedWeapon);
        }

    }

    void SetupResultScene()
    {
        Debug.Log("aaaaa");
       if (dishImage　!= null && dishSprite.Length > (int)selecteddish)
        {
            dishImage.sprite = dishSprite[(int)selecteddish];
        }
    }

    void ResetSelect()
    {
        PlayerPrefs.DeleteKey(WeaponKey);
        PlayerPrefs.DeleteKey(dishKey);
        PlayerPrefs.Save();
        selectedWeapon = WeaponType.Knife;
        selecteddish = dishType.Curry;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
