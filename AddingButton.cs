using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingButton : MonoBehaviour
{
    [SerializeField] private Slider _sliderHealth;

    public void OnClickButton(float healthIncrement)
    {
        StartCoroutine(SmoothChangeHealth(healthIncrement));
    }

    private IEnumerator SmoothChangeHealth(float healthIncrement)
    {
        for(int i = 0; i < 100; i++)
        {
            _sliderHealth.value += healthIncrement;
            yield return new WaitForSeconds(0.025f);
        }
    }
}