using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public  GameObject text1;
    public  GameObject text2;
    public  GameObject text3;
    public  GameObject Completed;
    public  GameObject button;

    private void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
        button.SetActive(false);
        Completed.SetActive(false);
    }

    public  void missionCompleted1()
    {
        text1.SetActive(false);
        Completed.SetActive(true);
        button.SetActive(true);
        
    }

    public void buttonAct()
    {
         Completed.SetActive(false); 
         button.SetActive(false);
         text2.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("YaseminScene");
    }
    
}
