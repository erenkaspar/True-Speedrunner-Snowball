using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float movementSpeed = 100f;
    public float jumpSpeed = 5f;
    bool jumpRequest = false;
    public GroundCheck groundCheck;
    public GameManager gameManager;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            jumpRequest = true;
            gameManager.isPaused = false;
        }
    }

    void FixedUpdate() {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(new Vector2(-movementSpeed * Time.deltaTime, 0));
                gameManager.isPaused = false;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(new Vector2(movementSpeed * Time.deltaTime, 0));
                gameManager.isPaused = false;
        }
        if (jumpRequest) {
            if (groundCheck.isGround) {
                rb.AddForce(new Vector2(0 , jumpSpeed), ForceMode2D.Impulse);
                jumpRequest = false;
            } else {
                jumpRequest = false;
            }
        }
    }
}
