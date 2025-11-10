using Unity.Cinemachine;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{

    [SerializeField] AudioClip coinPickupSFX;

    bool coinPickup = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bool coinPickup = true;
            if (coinPickup)
            {
                AudioSource.PlayClipAtPoint(coinPickupSFX, transform.position);
                Destroy(gameObject);
            }
        }
    }

}
