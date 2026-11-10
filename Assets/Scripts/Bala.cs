using UnityEngine;

public class Bala : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 5f);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.collider.GetComponentInParent<Enemy>();
        if (enemy != null) 
        { 
            if (enemy.vidaEnemigo >= 1)
            {
                enemy.restarVida();
               
            }
            else if (enemy.vidaEnemigo < 1)
            {
                enemy.Die();
                enemy.enemigoMuerto++;
            }
        }
        Destroy(gameObject);
    }
}
