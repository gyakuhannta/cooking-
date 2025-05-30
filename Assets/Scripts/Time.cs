using UnityEngine;
using UnityEngine.SceneManagement;

public class Time
{
    public float timelimit = 30f;

    void Update()
    {
        timelimit -= Time.deltatime;
    }
}
