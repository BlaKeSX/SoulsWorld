using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringPrueba : MonoBehaviour {


    public string nombre;
    public string saludo;
    public int numerogei;

    // Start is called before the first frame update
    void Start()
    {
        nombre="Blake";
        saludo="Hola ";
        string saludar;
        saludar= saludo + nombre;
        numerogei = 30;
        numerogei += 20;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numerogei);
    }
}
