using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    public static float raceTimer;
    public static int minutes;
    public static int seconds;
    public static int milliseconds;
    public TMPro.TextMeshProUGUI timerText;

    public void Update()
    {
        raceTimer += Time.deltaTime;

        minutes = Mathf.FloorToInt(raceTimer / 60f);
        seconds = Mathf.FloorToInt(raceTimer - (minutes * 60));
        milliseconds = Mathf.FloorToInt(raceTimer * 1000 - (seconds * 1000));

        timerText.text = string.Format("{0:0}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
