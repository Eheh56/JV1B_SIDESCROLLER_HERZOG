using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public BoxCollider2D trigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            respawn.Instance.respawnPoint = transform;
            trigger.enabled = false;
        }
    }
}
