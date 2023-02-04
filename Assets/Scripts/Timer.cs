using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countdownTime = 30.0f;
    public Text countdownText;
    public Button restartButton;

    void Start()
    {
        Invoke("StopGame", countdownTime);
    }

    void Update()
    {
        float timeLeft = countdownTime - Time.timeSinceLevelLoad;
        countdownText.text = Mathf.CeilToInt(timeLeft).ToString();
    }

    void StopGame()
    {
        Debug.Log("Time's up!");
        Time.timeScale = 0;
        restartButton.gameObject.SetActive(true);
        restartButton.onClick.AddListener(RestartGame);
    }

    void RestartGame()
    {
        Time.timeScale = 1;
        restartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
