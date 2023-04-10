using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{

    void Update()
    {
        karakterHareket();
    }

    void karakterHareket()
    {
        float hareket_hizi = 5f;

        if (Input.GetKey(KeyCode.A))
        {
            // A tuşuna tıklandığı zaman yapılacak işlemler.
            this.transform.Translate(-(hareket_hizi * Time.deltaTime),0,0);
            // Karakterin sola doğru gitmesini sağladık.
        }else if (Input.GetKey(KeyCode.D))
        {
            // D tuşuna tıklandığı zaman yapılacak işlemler.
            this.transform.Translate(hareket_hizi * Time.deltaTime, 0, 0);
            // Karakterin sağa doğru gitmesini sağladık.
        }
        else if (Input.GetKey(KeyCode.W))
        {
            // W tuşuna tıklandığı zaman yapılacak işlemler.
            this.transform.Translate(0, hareket_hizi * Time.deltaTime, 0);
            // Karakterin yukarı doğru gitmesini sağladık.
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // S tuşuna tıklandığı zaman yapılacak işlemler.
            this.transform.Translate(0, -(hareket_hizi * Time.deltaTime), 0);
            // Karakterin aşağı doğru gitmesini sağladık.
        }
    }
}