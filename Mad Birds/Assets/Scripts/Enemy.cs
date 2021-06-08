using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    [FormerlySerializedAs("_cloduParticlePrefab")] [SerializeField] private GameObject _cloudParticlePrefab;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        
        if (bird != null)
        {
            Death();
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();

        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
    }
}
