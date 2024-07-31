using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int checkpointNumber = 0;
    public Transform checkpointTransformOne;
    public Transform checkpointTransformTwo;
    public Transform checkpointTransformThree;
    public GameObject player;
    private Rigidbody2D playerRB;
    public float timer = 0;
    public Text timeText;
    public bool isPaused = true;
    public float _highscore = 10000;
    public FinishScript finishScript;

    //Escape Menu
    public GameObject escapeMenu;

    void Start() {
        player.transform.position = checkpointTransformOne.position; 
        playerRB = player.GetComponent<Rigidbody2D>();
        if (PlayerPrefs.GetFloat("highscore") != 0) {
            _highscore = PlayerPrefs.GetFloat("highscore");
            Debug.Log("_highscore");
        }
        if (_highscore == 0) {
            _highscore = 10000f;
            Debug.Log("çalıştım");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            Death();
        }

        if(player.transform.position.y < -5.5) {
            Death();
        }

        if (Input.GetKeyDown(KeyCode.T)) {
            Restart();
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (escapeMenu.activeSelf == false) {
                escapeMenu.SetActive(true);
                Time.timeScale = 0f;
            } else {
                Resume();
            }
        }

        if (isPaused == false) {
            timer = timer+ Time.deltaTime;
            timeText.text = timer.ToString("F2");
        }


    }

    public void Death() {
        if(checkpointNumber == 2) {
            player.transform.position = checkpointTransformThree.position;
            playerRB.velocity = Vector2.zero;
            playerRB.angularVelocity = 0f;
        } else if(checkpointNumber == 1) {
            player.transform.position = checkpointTransformTwo.position;
            playerRB.velocity = Vector2.zero;
            playerRB.angularVelocity = 0f;
        } else if (checkpointNumber == 0) {
            Restart();
        }
    }

    public void Restart() {
        checkpointNumber = 0;
        player.transform.position = checkpointTransformOne.position;
        playerRB.velocity = Vector2.zero;
        playerRB.angularVelocity = 0f;
        timer = 0f;
        isPaused = true;
        timeText.text = "0";
        finishScript.finishMenu.SetActive(false);
        finishScript.secretFinishMenu.SetActive(false);
        escapeMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Resume() {
        escapeMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenuButton() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
