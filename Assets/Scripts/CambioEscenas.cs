using UnityEngine;
using UnityEngine.SceneManagement;

/*
Script para cambio de escenas
Autor: Yael Sinuhe Grajeda Martinez
*/
public class CambioEscenas : MonoBehaviour
{
    public void Jugar(){
        SceneManager.LoadScene("SuperMario");
    }

    public void Interfaz(){
        SceneManager.LoadScene("InterfazUsuario");
    }

    public void Salir(){
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
