using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Uranyum : MonoBehaviour
{
    public UIManager UIManager;
    public RedFlashingLights RedFlashingLights;
    public TMP_Text uranyumValue;
    public static float _uranyumValue;
    public static bool lightOpen;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bana carpti");
        _uranyumValue++;
        uranyumValue.text= _uranyumValue.ToString();
        Destroy(gameObject);
        if (_uranyumValue == 1)
        {
            lightOpen = true;
           // RedFlashingLights.RedFlashingLightStop();
            UIManager.missionCompleted1();
        }
    }
}
