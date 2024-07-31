using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTwoScript : MonoBehaviour
{
    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void OnTriggerEnter2D(Collider2D collider) {
        gameManager.checkpointNumber = 1;
        spriteRenderer.sprite = newSprite;
    }
}
