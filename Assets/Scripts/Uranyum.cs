using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Uranyum : MonoBehaviour
{
    public TMP_Text uranyumValue;
    public static float _uranyumValue;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bana carpti");
        _uranyumValue++;
        uranyumValue.text= _uranyumValue.ToString();
        Destroy(gameObject);
    }
}
