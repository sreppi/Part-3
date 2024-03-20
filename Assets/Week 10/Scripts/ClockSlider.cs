using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockSlider : MonoBehaviour
{
    public Slider slider;
    float timer;
    public float speed = 1;
    void Update()
    {
        timer += Time.deltaTime * speed;
        timer = timer % 60;
        slider.value = timer;
    }
}
