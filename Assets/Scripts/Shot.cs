using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    
    public float shotForce = 1500;
    public float shotRate = 0.5f;
    
    private float shotRateTime = 0;
    
    public int damage = 1; // Daño que inflige la bala
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Time.time>shotRateTime)
            {
                GameObject newBullet;
                
                newBullet= Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);
                
                shotRateTime = Time.time + shotRate;
                
                Destroy(newBullet, 2);
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
        {
            // Verificar si la bala colisiona con un enemigo
            if (other.CompareTag("enemigo"))
            {
                // Obtener el componente Enemy del objeto enemigo
                Enemy enemy = other.GetComponent<Enemy>();
                
                // Si el componente Enemy no es nulo, aplicar daño al enemigo
                if (enemy != null)
                {
                    //enemy.TakeDamage(damage);
                }
                
                // Destruir la bala al impactar con el enemigo
                Destroy(gameObject);
            }
    }
    
}
