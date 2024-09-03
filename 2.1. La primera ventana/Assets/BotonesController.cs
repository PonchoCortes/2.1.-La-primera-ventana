using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar las escenas

public class BotonesController : MonoBehaviour
{
    // Función para reiniciar la escena actual
    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Función para salir al menú principal (primera escena)
    public void SalirAlMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Función para salir del juego (solo funciona en el build)
    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
