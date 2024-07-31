using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    public GameManager gameManager;
    public Text scoreText;
    public Text highscoreText;
    public GameObject finishMenu;
    public GameObject secretFinishMenu;
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            gameManager.isPaused = true;
            if (gameManager.timer < gameManager._highscore) {
                gameManager._highscore = gameManager.timer;
                PlayerPrefs.SetFloat("highscore",gameManager.timer);
                PlayerPrefs.Save();
            }
            scoreText.text = gameManager.timer.ToString("F2");
            if(gameManager._highscore != 10000) {
                highscoreText.text = gameManager._highscore.ToString("F2");
            }
            finishMenu.SetActive(true);
            secretFinishMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
