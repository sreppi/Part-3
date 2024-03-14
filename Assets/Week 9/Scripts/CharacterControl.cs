using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI className;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Debug.Log(SelectedVillager.ToString());
    }

    void FixedUpdate()
    {
        className = GetComponent<TextMeshProUGUI>();
        className.text = SelectedVillager.ToString(); // I can't seem to get this to work outside of the script. This is causing a lot of issues.
    }

}
