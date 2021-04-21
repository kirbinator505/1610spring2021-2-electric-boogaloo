using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText, gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;

    private float spawnRate = 1.0f;
    private int score;

    void Start()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
         yield return new WaitForSeconds(spawnRate);
         int index = Random.Range(0, targets.Count);
         Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
    }
}
