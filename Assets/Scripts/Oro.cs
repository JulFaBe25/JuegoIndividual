using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oro : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;

    private void Update()
    {
        textoPuntos.text = puntos.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Puntos"))
        {
            Debug.Log("Se estan tomando puntos");
            Destroy(other.gameObject);
            puntos++;

        }
    }
}
