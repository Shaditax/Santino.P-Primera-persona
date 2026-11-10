using UnityEngine;
using UnityEngine.SceneManagement;

public class Menú : MonoBehaviour
{
    public void iniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void volvermenu()
    {
        SceneManager.LoadScene("Menú");
    }
}
