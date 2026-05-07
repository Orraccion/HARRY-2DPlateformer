using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the thing that hit us has a "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item Collected!");
            // You can call a ScoreManager here later
            Destroy(gameObject); // The item disappears
        }
    }
}
