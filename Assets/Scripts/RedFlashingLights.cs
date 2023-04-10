using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RedFlashingLights : MonoBehaviour
{
    public static Light _light;
    void Start()
    {
        _light= GetComponent<Light>();
        RedFlashingLightActive();
        StartCoroutine(LightControl());
    }

    public void RedFlashingLightActive()
    {
        _light.color = Color.red;
        
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(_light.DOColor(Color.red, 0.2f));
        mySequence.Append(_light.DOColor(Color.black, 0.3f));
        mySequence.SetLoops(-1, LoopType.Yoyo);
    }

   /* public void RedFlashingLightStop()
    {
        _light.color = Color.white;
    }*/
    IEnumerator LightControl() {
        yield return new WaitForSeconds(1f);
        if(Uranyum.lightOpen)
            _light.color = Color.white;
    }
}