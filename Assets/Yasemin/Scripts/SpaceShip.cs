using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float horizontalSpeed = 2f;

    private bool isUp = true;

    private const float maxX = 7.7f;
    private const float minX = -4.4f;
    private const float minY = -1.7f;
    private const float maxY = 4f;


    void Update()
    {
        if (isUp)
        {
            // Gemi yukarý doðru hareket eder
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

            // Sað-Sol hareketi için girdi alýnýr
            float horizontal = Input.GetAxis("Horizontal");

            // Gemi yatayda hareket eder
            transform.Translate(Vector3.right * horizontal * horizontalSpeed * Time.deltaTime);

            // Eðer gemi ekranýn üstünden çýkarsa, aþaðýya döndürülür ve hareket yönü tersine çevrilir
            if (transform.position.y >  maxY)
            {
                transform.Rotate(Vector3.forward, 180f);
                isUp = false;
            }
        }
        else
        {
           
            transform.Translate(-Vector3.down * moveSpeed * Time.deltaTime);

            // Sað-Sol hareketi için girdi alýnýr
            float horizontal = Input.GetAxis("Horizontal");

            // Gemi yatayda hareket eder
            transform.Translate(Vector3.right * horizontal * horizontalSpeed * Time.deltaTime);

            // Eðer gemi ekranýn altýndan çýkarsa, yukarýya döndürülür ve hareket yönü tersine çevrilir
            if (transform.position.y < minY)
            {
                transform.Rotate(Vector3.forward, 180f);
                isUp = true;
            }
        }
    }
}

    
