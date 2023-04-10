using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishPart : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public  GameObject Completed;
    public GameObject text1;
    public GameObject button;


    private void OnTriggerEnter(Collider other)
    {
        text1.SetActive(false);
        Completed.SetActive(true);
        button.SetActive(true);
    }
    public void sertifikaButton()
    {
        image1.SetActive(true);
        image2.SetActive(true);
    }
}
