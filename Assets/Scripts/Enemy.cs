using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Método llamado cuando este objeto colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisionamos tiene la etiqueta "Bala"
        if (collision.gameObject.CompareTag("Bala"))
        {
            // Si colisionamos con una bala, desactivamos este objeto para que desaparezca
            gameObject.SetActive(false);

            // Destruimos la bala que colisionó
            Destroy(collision.gameObject);
        }
    }
}