using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Image timerBar;
    public float maxTime = 120f;
    private float timeLeft;
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
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void TimeBooster()
    {
        timeLeft += 6f;
        timerBar.fillAmount = timeLeft / maxTime;
    }
}
