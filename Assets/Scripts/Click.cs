using UnityEngine;

public class Click : MonoBehaviour
{
    void OnMouseDown()
    {
        GameManager.Instance.AddScore();
        Destroy(gameObject);
    }
    
}
