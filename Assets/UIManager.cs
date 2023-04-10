using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    private void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
    }
    
    public void TextChanger()
    {
        if (text1.activeInHierarchy)
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
        else if (text2.activeInHierarchy)
        {
            text2.SetActive(false);
            text3.SetActive(true);
        }
        else if (text3.activeInHierarchy)
        {
            text3.SetActive(false);
        }
    }
}
