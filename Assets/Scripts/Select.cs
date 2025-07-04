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
    public Text dishNameText;
<<<<<<< HEAD

    public Text weapontext;
    public Text weaponnameText;
    public Sprite[] weaponsprite;
    public Image weaponImage;
    public Sprite[] weaponsprite2;
    public Image weaponImage2;

=======
>>>>>>> 1bbeba954621208ea2e720dea6b0fe44a86d95e6

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

        if (scene == "SampleScene")
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

         // 料理画像をすぐ表示
        if (dishImage != null && dishSprite.Length > index)
           {
               dishImage.sprite = dishSprite[index];
           }
        // 料理名テキストを更新
        if (dishNameText != null)
        {
            string[] dishNames = { "カレー", "シチュー", "酢豚","鍋", "お好み焼き" };
            if (index >= 0 && index < dishNames.Length)
            {
                dishNameText.text = dishNames[index];
            }
        }

    }

    void SetupMainScene()
    {
       /* if(weaponPrefab.Length > 0)
        {
            for(int i = 0; i < weaponPrefab.Length; i++)
                weaponPrefab[i]?.SetActive(i == (int)selectedWeapon);
        }*/
        int index = (int)selectedWeapon;

        // 武器画像を表示
        if (weaponImage != null && weaponsprite.Length > index)
        {
            weaponImage.sprite = weaponsprite[index];
        }
        // 武器画像を表示
        if (weaponImage2 != null && weaponsprite2.Length > index)
        {
            weaponImage2.sprite = weaponsprite2[index];
        }
        // 武器名テキストを表示
        if (weaponnameText != null)
        {
            string[] weaponnames = { "包丁", "斧", "Nodata", "Nodata", "Nodata" };
            if (index >= 0 && index < weaponnames.Length)
            {
                weaponnameText.text = weaponnames[index];
            }
        }

        // 武器説明テキストを表示
        if (weapontext != null)
        {
            string[] weaponDescriptions = {
            "マウスカーソルの下にある具罪を切るぞ！",
            "一定範囲の具罪を右クリックで切るぞ！",
            "Nodata", "Nodata", "Nodata"
        };
            if (index >= 0 && index < weaponDescriptions.Length)
            {
                weapontext.text = weaponDescriptions[index];
            }
        }
    }

    void SetupResultScene()
    {
        Debug.Log("aaaaa");
       if (dishImage　!= null && dishSprite.Length > (int)selecteddish)
        {
            dishImage.sprite = dishSprite[(int)selecteddish];
        }

        if (dishNameText != null)
        {
            string[] dishNames = { "カレー", "シチュー","酢豚", "鍋", "お好み焼き" };
            dishNameText.text = dishNames[(int)selecteddish];
        }
    }

    public void ResetSelect()
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
