using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioFixacao : MonoBehaviour
{
    public int numVidas = 10;
    public float numMoeda = 10;
    public string nome = "Miller";
    public float energia = 10;

    public float soma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Somar();
    }

    void Somar()
    {
        if (Input.GetKeyDown("s"))
        {
            soma = numVidas + energia;
            Debug.Log("Vamos somar o valor da sua vida e da sua energia");
            Debug.Log($"O valor da soma entre {numVidas} + {energia} é de: {soma}");
        }
    }
}
