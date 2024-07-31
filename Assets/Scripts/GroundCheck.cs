using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround = false;
    public Transform playerTransform;

    void Update() {
        transform.position = new Vector2(playerTransform.position.x, playerTransform.position.y-0.501f);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Ground")) {
            isGround = true;
        }
    }
    void OnTriggerStay2D(Collider2D collider) {
        if(collider.CompareTag("Ground")) {
            isGround = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider) {
        if(collider.CompareTag("Ground")) {
            isGround = false;
        }
    }
}
