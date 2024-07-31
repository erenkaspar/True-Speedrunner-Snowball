using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointThreeScript : MonoBehaviour
{

    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            gameManager.checkpointNumber = 2;
            spriteRenderer.sprite = newSprite;
        }
    }

}
