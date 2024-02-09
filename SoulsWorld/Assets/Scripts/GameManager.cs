using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform playerSpawnPoint;
    public GameObject jugador;
    public string playerTag;
    private static GameManager _instance;
    public static GameManager instance { get; private set; } 
    // Start is called before the first frame update

    private void Awake()
    {
        if (_instance = null)
        {
            _instance = this;
        }
    }
    void Start()
    {
        
        jugador = GameObject.FindGameObjectWithTag(playerTag);
        jugador.transform.position = playerSpawnPoint.position;
    }

   
}
