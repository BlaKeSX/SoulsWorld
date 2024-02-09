using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Atributos))]
public class PlayerController : MonoBehaviour {

    private InputPlayer inputJugador;
    private Transform transformada;
    public float horizontal;
    public float vertical;
    private Rigidbody2D miRigidbody2D; //camelCase
    public Animator animator;
    private SpriteRenderer miSprite;
    public Atributos atributosJugador;
    private Atacante atacante;
    public int correrHashCode;
    public int[] arrayPrueba = new int[5];
    public WeaponRotation weaponScript;
    public Sprite katana;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start(){
        arrayPrueba[0] = 1;
        arrayPrueba[1] = 2;
        arrayPrueba[2] = 3;
        arrayPrueba[3] = 4;
        arrayPrueba[4] = 5;
        atributosJugador = GetComponent<Atributos>();
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        miRigidbody2D = GetComponent<Rigidbody2D>(); //El Rigidvody2D de este GameObject
        animator = GetComponent<Animator>();
        miSprite = GetComponent<SpriteRenderer>();
        atacante = GetComponent<Atacante>();
        correrHashCode = Animator.StringToHash("Corriendo");
        Debug.Log(inputJugador.VariableFloatPrivada);
        inputJugador.VariableFloatPrivada = 3.14f;
        Debug.Log(inputJugador.VariableFloatPrivada);
        //weaponScript = GetComponentInChildren<WeaponRotation>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = inputJugador.ejeHorizontal;
        vertical = inputJugador.ejeVertical;

        if(Input.GetButtonDown("Atacar"))
        {
            atacante.Atacar(inputJugador.direccionMirada, atributosJugador.ataque);
        }


        VoltearSprite();

        if (Input.GetButtonDown("Atacar"))
        {
            animator.SetBool("Atacando", true);
            
        }
        
    }

    private void VoltearSprite()
    {

        if (horizontal != 0 || vertical != 0)
        {
            SetXYAnimator();
            animator.SetBool(correrHashCode, true);
        }
        else
        {
            animator.SetBool(correrHashCode, false);
        }

    }
        private void SetXYAnimator()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }

    void FixedUpdate()
    {
        if (animator.GetBool("Atacando"))
        {
            miRigidbody2D.velocity = Vector2.zero;
        }
        else
        {
            Vector3 vectorVelocidad = new Vector3(horizontal, vertical, 0) * atributosJugador.velocidad;
            //miRigidbody2D.AddForce(fuerza);
            miRigidbody2D.velocity = vectorVelocidad;
        }
        //moveremos modificando la transformada
        

        ///------Movimiento------///
       
    }

    void ControlAtacar()
    {
        atacante.Atacar(inputJugador.direccionMirada, atributosJugador.ataque);
        animator.SetBool("Atacando", false);
    }
}
