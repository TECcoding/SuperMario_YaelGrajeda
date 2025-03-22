using UnityEngine;

/*
Detectar si el personaje esta en el piso
Autor: Yael Sinuhe Grajeda Martinez
*/
public class EstadoPersonaje : MonoBehaviour
{

    public static bool enPiso { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enPiso = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}