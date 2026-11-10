using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   

public class Enemy : MonoBehaviour
{
    public int vidaEnemigo = 100;
    public int daño;


    public Slider BarraEnemiga;

    private void Update()
    {
        BarraEnemiga.value = vidaEnemigo;
    }

    public void restarVida()
    {
        vidaEnemigo -= daño;
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
