using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;



public class PlayManager : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ¶ƒNƒŠƒbƒN
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                var targetScript = hit.collider.GetComponent<Prefab>();
                if (targetScript != null)
                {
                    targetScript.OnClickedByRay(); // “Æ©‚ÌŠÖ”‚ğŒÄ‚Ô
                }
            }
        }
    }
}
