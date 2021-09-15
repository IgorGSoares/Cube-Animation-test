using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidertest : MonoBehaviour
{
    public Slider slider;
    public float speed = 1;
    float pos = 0;

    void Update()
    {
        pos += speed * Time.deltaTime;
        slider.value = Mathf.PingPong(pos, slider.maxValue);
    }
}
