using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float hareketHizi = 5f;
    public float yanHareketHizi = 2f;

    private bool yukariMi = true;

    private const float maxX = 7.7f;
    private const float minX = -4.4f;
    private const float minY = -1.7f;
    private const float maxY = 4f;


    void Update()
    {
        if (yukariMi)
        {
            // Gemi yukar� do�ru hareket eder
            transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);

            // Sa�-Sol hareketi i�in girdi al�n�r
            float horizontal = Input.GetAxis("Horizontal");

            // Gemi yatayda hareket eder
            transform.Translate(Vector3.right * horizontal * yanHareketHizi * Time.deltaTime);

            // E�er gemi ekran�n �st�nden ��karsa, a�a��ya d�nd�r�l�r ve hareket y�n� tersine �evrilir
            if (transform.position.y >  maxY)
            {
                transform.Rotate(Vector3.forward, 180f);
                yukariMi = false;
            }
        }
        else
        {
            // Gemi a�a�� do�ru hareket eder
            transform.Translate(-Vector3.down * hareketHizi * Time.deltaTime);

            // Sa�-Sol hareketi i�in girdi al�n�r
            float horizontal = Input.GetAxis("Horizontal");

            // Gemi yatayda hareket eder
            transform.Translate(Vector3.right * horizontal * yanHareketHizi * Time.deltaTime);

            // E�er gemi ekran�n alt�ndan ��karsa, yukar�ya d�nd�r�l�r ve hareket y�n� tersine �evrilir
            if (transform.position.y < minY)
            {
                transform.Rotate(Vector3.forward, 180f);
                yukariMi = true;
            }
        }
    }
}

    
