using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ReloadLevel", 3.0f);
    }

    // Update is called once per frame
    void ReloadLevel()
    {
        SceneManager.LoadScene("_TestMarco");
    }
}
