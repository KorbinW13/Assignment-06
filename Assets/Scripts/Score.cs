using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public static float CurrentScore = 0;
    public static float TotalScore = 0;
    public static float Lives = 3;
    static string writeScore;

    public Text ScoreText;
    public Text LivesText;
    public Text PlayerText;


    void Start()
    {
        ScoreText.text = "Score: " + CurrentScore;
        LivesText.text = "Lives: " + Lives;
        PlayerText.text = InputName.PlayerName;
    }

    void Update()
    {
        ScoreText.text = "Score: " + CurrentScore;
        LivesText.text = "Lives: " + Lives;
        PlayerText.text = InputName.PlayerName;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            GetComponent<Collider>().enabled = false;
            Debug.Log("WE DIED!");
            TotalScore = TotalScore + CurrentScore;
            writeScore = TotalScore.ToString();
            CurrentScore = 0;
            Lives--;
            if (Lives < 0)
            {
                Invoke("GameOver", 0.5f);
                GetComponent<WriteScores>().AddNewScore(InputName.PlayerName, writeScore);
            }
            else
            {
                Invoke("ResetGame", 0.2f);
                TotalScore = TotalScore + CurrentScore;
            }
                
        }

        if (col.gameObject.CompareTag("PickUp"))
        {
            Destroy(col.gameObject);
            AudioSource coin = GetComponent<AudioSource>();
            coin.Play();
            CurrentScore = CurrentScore + 100;
            RandomPointOnNavMesh.ObjectDestroyed = true;
        }
    }

    void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
