using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void StartGame()
    {
        RandomPointOnNavMesh.ObjectDestroyed = false;
        Score.CurrentScore = 0;
        Score.TotalScore = 0;
        Score.Lives = 3;
        Pause.gameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
