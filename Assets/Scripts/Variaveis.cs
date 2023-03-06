using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    /*Este script é só um teste para variaveis e 
     * metodos que podem ser utilizados dentro de games;
     */

    //[SerializeField] // Permite que as variaveis sejam vilusalizadas dentro do inspector do Unity
    [SerializeField] private string name = "Personagem";
    [SerializeField] private int life = 0;
    [SerializeField] private float speed = 0f;
    [SerializeField] private float carteira = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Info();
        Money();
    }

    private void Info()
    {
        if (Input.GetKeyDown("n"))
        {
            Debug.Log($"O nome do seu personagem é {name}");
        }

        if (Input.GetKeyDown("l"))
        {
            Debug.Log($"A vida inicial de {name} é {life}");
        }

        if (Input.GetKeyDown("s"))
        {
            Debug.Log($"A velocidade inicial do de {name} é {speed}");
        }

        if (Input.GetKeyDown("i"))
        {
            Debug.Log($"{name} tem R${carteira} em sua carteira.");
        }

    }

    void Money()
    {
        if (Input.GetKeyDown("c"))
        {
            carteira += 3.69f;
        }
    }
}
