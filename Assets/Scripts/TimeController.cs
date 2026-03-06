using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float timeScale = 1f;

    public GameObject pausePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = timeScale;

        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
