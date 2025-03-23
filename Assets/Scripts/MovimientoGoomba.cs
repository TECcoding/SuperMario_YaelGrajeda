using UnityEngine;
using UnityEngine.UIElements;

/*
Movimiento de Goomba de un lado al otro
Autor: Yael Sinuhe Grajeda Martinez
*/
public class MovimientoGoomba : MonoBehaviour
{

    public float speed = 2f;
    public Transform pointA;
    public Transform pointB;

    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointB.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Mover hacia el objetivo
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Si llego al punto objetivo, cambiar a otro punto
        if (Vector2.Distance(transform.position, target) < 0.1f)
        {
            if (target == pointB.position)
            {
                target = pointA.position;
            }
            else {
                target = pointB.position;
            }
        }
    }
}
