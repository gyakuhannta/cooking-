using UnityEngine;
using UnityEngine.UI;

public class Pose : MonoBehaviour
{
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
    }
    public void ShowPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0f; // ƒQ[ƒ€‘S‘Ì‚ğ’â~
    }
    public void HidePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1f; // ÄŠJ
    }
}
