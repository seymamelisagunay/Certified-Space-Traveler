using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour
{
    private float speed = 5;

    public GameObject explosion;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("SpaceShip"))
        {
            
            collision.gameObject.SetActive(false);
            var explosionObject = Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(explosionObject, 0.5f);
        }

        if (gameObject.CompareTag("Spark"))
        {
            gameObject.SetActive(false); 
        }
    }


}
