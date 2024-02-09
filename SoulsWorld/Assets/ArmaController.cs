using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaController : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private bool mirandoDerecha = true;

     public float offsetEspalda = 0.253f;


    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float direccion = Input.GetAxis("Horizontal");
        if((direccion<0 && mirandoDerecha) || (direccion > 0 && !mirandoDerecha))
        {
            FlipArma();
        }
    }

    void FlipArma()
    {
        // Voltear el arma
        mirandoDerecha = !mirandoDerecha;

        // Cambiar la escala en el eje X para voltear el objeto
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;

        // Ajustar la posición en el eje X para posicionar la guadaña en la espalda
        Vector3 posicion = transform.localPosition;
        posicion.x = mirandoDerecha ? -offsetEspalda : offsetEspalda;
        transform.localPosition = posicion;
    }
}
