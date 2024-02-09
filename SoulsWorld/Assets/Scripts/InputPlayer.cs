using System.Collections;
using System.Collections.Generic;
using UnityEngine; // NameSpace es un cojunto de clases
//Alcance---> //class-----> //InputPlayer ---> Nombre de la clase //:MonoBehaviour ----> Clase Heredada
public class InputPlayer : MonoBehaviour{

    //Joystick ejeHorizontal&Vertical -1,1
   [HideInInspector]  public float ejeHorizontal{get;private set;}
   [HideInInspector] public float ejeVertical  {get;private set;}
   [HideInInspector] public bool atacar {get; private set;}
   [HideInInspector] public bool habilidad1 {get;private set;}
   [HideInInspector] public bool habilidad2    {get;private set;}
   [HideInInspector] public bool inventario  {get;private set;}
   [HideInInspector] public bool interactuar   {get;private set;}
    
    [HideInInspector]
    public Vector2 direccionMirada = new Vector2(0, -1f);

    private float variableFloatPrivada;
    public float VariableFloatPrivada
    {
        get
        {
            Debug.Log("Obetniendo mi propiedad VariableFloatPrivada");
            return variableFloatPrivada;
        }
        set
        {
            Debug.Log("Asignando mi valor VariableFloatPrivada " + value);
            variableFloatPrivada = value; //value es igual al valor q yo le asigne a mi propiedad
        }
    }

    // Start is called before the first frame update //Vacio
 

    // Update is called once per frame
    void Update()
    {
        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");

        //Definir eje de movimiento
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");

        DeterminarDireccionMirada();
       // Debug.DrawLine(transform.position, transform.position + (Vector3)direccionMirada.normalized * 1,Color.green);
    }

    private void DeterminarDireccionMirada()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            direccionMirada.x = ejeHorizontal;
            direccionMirada.y = ejeVertical;
        }
    }

}
