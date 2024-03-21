using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    public static Villager SelectedVillager { get; private set; }
    float interpolation;
    public Vector3 startSize = new Vector3 (0.5f, 0.5f, 1);
    public Vector3 endSize = new Vector3(2, 2, 1);
    
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }

    public void CharacterSizeChange(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.transform.localScale = Vector3.Lerp(startSize, endSize, (interpolation / 2));
        }
    }

    private void Start()
    {
        Instance = this;
    }


    /*private void Update()
    {
        if(SelectedVillager != null)
        {
            currentSelection.text = SelectedVillager.GetType().ToString();
        }
    }*/
}
