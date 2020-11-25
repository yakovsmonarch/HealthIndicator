using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private Slider _sliderHealth;
    [SerializeField] private float _timeIncrement;

    public void OnClickButton(float healthIncrement)
    {
        StartCoroutine(SmoothChangeHealth(healthIncrement, _timeIncrement));
    }

    private IEnumerator SmoothChangeHealth(float healthIncrement, float timeIncrement)
    {
        for(int i = 0; i < 100; i++)
        {
            _sliderHealth.value += healthIncrement;
            yield return new WaitForSeconds(timeIncrement);
        }
    }
}