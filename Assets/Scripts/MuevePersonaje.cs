using UnityEngine;

/*
Movimiento de personaje
Autor: Yael Sinuhe Grajeda Martinez
*/
public class MuevePersonaje : MonoBehaviour
{
    // Velocidad

    [SerializeField]
    private float velocidadX;

    [SerializeField] // Le doy permiso a Unity de acceder a la variable
    private float velocidadY;

    // RigidBody para usar la fisica
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // FixUpdate is called 50 times per second
    void FixedUpdate()
    {
       float movHorizontal = Input.GetAxis("Horizontal");
       float movVertical = Input.GetAxis("Vertical");

       if (movVertical > 0) {
        rb.linearVelocity = new Vector2(movHorizontal*velocidadX, movVertical*velocidadY); 
       } else {
        rb.linearVelocity = new Vector2(movHorizontal*velocidadX, rb.linearVelocityY); 
       }
       
    }

}
