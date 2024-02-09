using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarSprite : MonoBehaviour
{
    public Sprite spriteNormal;
    public Sprite spritePresionado;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer no encontrado en el objeto.");
        }
    }

    void Update()
    {
        // Verificar si se presiona un botón (por ejemplo, la tecla 'P')
        if (Input.GetButtonDown("Atacar"))
        {
            // Cambiar el sprite al sprite presionado
            spriteRenderer.sprite = spritePresionado;
        }

        else
        {
            spriteRenderer.sprite = spriteNormal;
        }
        
    }
}


