using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacable : MonoBehaviour
{
    private Salud miSalud;
    private Rigidbody2D miRidbody;

    private void Start()
    {
        miRidbody = GetComponent<Rigidbody2D>();
        miSalud = GetComponent<Salud>();
    }
    public void RecibirAtaque()
    {
        miSalud.SaludActual -= 1;
    }

    public void RecibirAtaque( Vector2 direccionDeAtaque, int danio)
    {
        miSalud.modificarSaludActual(-danio);
        miRidbody.AddForce(direccionDeAtaque * danio*100);
        
    }
}

