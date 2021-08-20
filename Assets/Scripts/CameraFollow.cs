
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //offset, so that camera position can be changed. Z-axis so that PlayerDot can be seen and Y-Axis so that camera goes before playerDot
    public float moveSpeed; //speed for camera movement

    private void FixedUpdate()
    {
        transform.position = (new Vector3(player.position.x, player.position.y, player.position.z) + offset) * moveSpeed;
    }
}
