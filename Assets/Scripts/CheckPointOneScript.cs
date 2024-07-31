using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointOneScript : MonoBehaviour
{

    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;


    void Start() {

    }

    void OnTriggerEnter2D(Collider2D collider) {
        gameManager.checkpointNumber = 0;
        spriteRenderer.sprite = newSprite;
    }
}
