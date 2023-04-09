using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBooster : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Timer.TimeBooster();
    }
}
