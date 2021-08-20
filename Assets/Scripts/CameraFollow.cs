
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float moveSpeed;

    private void FixedUpdate()
    {
        transform.position = (new Vector3(player.position.x, player.position.y, player.position.z) + offset) * moveSpeed;
    }
}
