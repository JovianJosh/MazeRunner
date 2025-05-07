using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;  // The player to follow
    public Vector3 offset;    // The offset from the player

    void Update()
    {
        // Smoothly follow the player's position in 2D (X, Y only)
        transform.position = Vector3.Lerp(transform.position, player.position + offset, 0.1f);

        // Lock the camera's Z position (2D game, no Z movement)
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
