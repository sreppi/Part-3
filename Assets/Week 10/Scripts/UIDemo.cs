using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
    public void SliderValueGotChanged(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation/60));
    }

    public void DropdownSelectionHasChanged(int value) //int or Int32
    {
        Debug.Log(dropdown.options[value].text);
    }
}

