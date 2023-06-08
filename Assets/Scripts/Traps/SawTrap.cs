using UnityEngine;

public class SawTrap : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Health>().TakeDamage(damage);
    }
}
