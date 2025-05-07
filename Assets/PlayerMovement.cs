using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input for horizontal and vertical movement (WASD or arrow keys)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Create movement vector
        Vector2 movement = new Vector2(moveX, moveY);

        // Apply movement to the player object
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
