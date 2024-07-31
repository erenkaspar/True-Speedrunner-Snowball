using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public float highScore = 0;
    public Text highScoreText;

    void Start() {
        if (PlayerPrefs.GetFloat("highscore") > 1) {
            highScore = PlayerPrefs.GetFloat("highscore");
        }

        highScoreText.text = highScore.ToString("F2");
    }

    void Update() {
        highScoreText.text = highScore.ToString("F2");
    }

    public void PlayButton() {
        SceneManager.LoadScene(1);
    }

    public void LeaderboardButton() {

    }

    public void QuitButton() {
        Application.Quit();
    }

}
