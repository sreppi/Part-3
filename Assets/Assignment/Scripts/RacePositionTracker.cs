using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacePositionTracker : MonoBehaviour
{
    public Car car;
    public Car2 car2;
    public Car3 car3;
    public TMPro.TextMeshProUGUI player1RacePosition;
    public TMPro.TextMeshProUGUI player2RacePosition;
    public TMPro.TextMeshProUGUI player1RaceLapPosition;
    public TMPro.TextMeshProUGUI player2RaceLapPosition;

    void Start()
    {
        
    }

    void Update()
    {
        player1RaceLapPosition.text = car.currentLap.ToString();
        player2RaceLapPosition.text = car2.currentLap.ToString();

        // Probably need to use arrays and loops to make a better code
        // At the moment, the yellow car's position will not affect the race position

        if (car.currentLap > car2.currentLap)
        {
            player1RacePosition.text = "1st";
            player2RacePosition.text = "2nd";
        }
        else if (car.currentLap == car2.currentLap)
        {
            if (car.nextCheckpoint > car2.nextCheckpoint)
            {
                player1RacePosition.text = "1st";
                player2RacePosition.text = "2nd";
            }
            else if (car.nextCheckpoint == car2.nextCheckpoint)
            {
                if (car.playerDistanceFromCheckPoint < car2.playerDistanceFromCheckPoint)
                {
                    player1RacePosition.text = "1st";
                    player2RacePosition.text = "2nd";
                }
                else
                {
                    player1RacePosition.text = "2nd";
                    player2RacePosition.text = "1st";
                }
            }
            else if (car.nextCheckpoint < car2.nextCheckpoint)
            {
                player1RacePosition.text = "2nd";
                player2RacePosition.text = "1st";
            }
        }
        else if (car.currentLap > car2.currentLap)
        {
            player1RacePosition.text = "2nd";
            player2RacePosition.text = "1st";
        }
        
    }
}
