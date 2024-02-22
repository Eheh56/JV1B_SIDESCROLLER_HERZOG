using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();

        if (collectible != null)
        {
            collectible.Collect();
        }
    }
    public interface ICollectible
    {
        public void Collect();
    }
}