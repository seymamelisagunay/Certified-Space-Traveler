using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openButton : MonoBehaviour
{

    public GameObject button2;

    private void OnTriggerEnter(Collider other)
    {
        if(Uranyum._uranyumValue >= 6) 
            button2.SetActive(true);
    }
}
