using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArma : MonoBehaviour
{
 
    public float velocidadRotacion = 5f;

    void Update()
    {
        // Obtener entrada del teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcular ángulo de rotación
        if (horizontal != 0f || vertical != 0f)
        {
            float angulo = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
            Quaternion rotacionDeseada = Quaternion.Euler(new Vector3(0f, 0f, angulo));

            // Rotar gradualmente hacia la dirección deseada
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionDeseada, Time.deltaTime * velocidadRotacion);
        }
    }
}

