using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;         // Reference to the player's transform
    public float boundaryX = 5f;     // Horizontal boundary before the camera starts following
    public float boundaryY = 5f;     // Vertical boundary before the camera starts following
    public float smoothSpeed = 5f;  // Speed at which the camera moves

    private Vector3 targetPosition; // The camera's target position

    void LateUpdate()
{
    // Get the camera's current position
    Vector3 cameraPosition = transform.position;

    // Calculate the offset between the player and the camera
    float offsetX = player.position.x - cameraPosition.x;
    float offsetY = player.position.y - cameraPosition.y;

    // Check if the player is outside the defined boundaries
    if (Mathf.Abs(offsetX) > boundaryX || Mathf.Abs(offsetY) > boundaryY)
    {
        // Update the target position to follow the player
        targetPosition = new Vector3(player.position.x, player.position.y, cameraPosition.z);

        // Smoothly move the camera towards the target position
        transform.position = Vector3.Lerp(cameraPosition, targetPosition, smoothSpeed * Time.deltaTime);
    }
}

    private void OnDrawGizmos()
    {
        // Draw the camera boundaries in the editor for debugging
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(boundaryX * 2, boundaryY * 2, 0));
    }
    /*void LateUpdate()
{
    Vector3 cameraPosition = transform.position;

    // Calculate the offset between the player and the camera
    float offsetX = player.position.x - cameraPosition.x;
    float offsetY = player.position.y - cameraPosition.y;

    if (Mathf.Abs(offsetX) > boundaryX || Mathf.Abs(offsetY) > boundaryY)
    {
        targetPosition = new Vector3(player.position.x, player.position.y, cameraPosition.z);
        targetPosition = SnapToPixelGrid(targetPosition); // Snap to grid
        transform.position = Vector3.Lerp(cameraPosition, targetPosition, smoothSpeed * Time.deltaTime);
    }
}

Vector3 SnapToPixelGrid(Vector3 position)
{
    float pixelsPerUnit = 16; // Adjust based on your game's pixel art settings
    position.x = Mathf.Round(position.x * pixelsPerUnit) / pixelsPerUnit;
    position.y = Mathf.Round(position.y * pixelsPerUnit) / pixelsPerUnit;
    return position;
}
*/
}
