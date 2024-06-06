using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajescript : MonoBehaviour
{
    public int nivelHambre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }
     void OnTriggerEnter(Collider other)
    {
        alimentoscript alimento;
        alimento = other.GetComponent<alimentoscript>();
        if (alimento)
        {
            TomarAlimento(alimento.valorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
