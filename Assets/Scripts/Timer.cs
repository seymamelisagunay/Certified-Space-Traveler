using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private static Image timerBar;
    public static float maxTime = 120f;
    private static float timeLeft;
    public GameObject timesUpText;
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }
    
    void Update()
    {
        if (timeLeft > 0)
        {
           // Debug.Log(timeLeft);
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public static void TimeBooster()
    {
        timeLeft += 6f;
        if (timeLeft > 120)
            timeLeft = 120;
        timerBar.fillAmount = timeLeft / maxTime;
        
    }
}
