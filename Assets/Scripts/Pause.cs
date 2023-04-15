using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseTextObject;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        pauseTextObject.SetActive(true);
        gameIsPaused = true;
    }
    void ResumeGame()
    {
        pauseTextObject.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}
