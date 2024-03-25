using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public GameObject player1;
    public GameObject player2;
    public float player1DistanceFromCheckPoint;
    public float player2DistanceFromCheckPoint;
    public float player1TriangleArea;
    public TMPro.TextMeshProUGUI player1RacePosition;
    public TMPro.TextMeshProUGUI player2RacePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        float lengthOfCheckpoint = Vector2.Distance(point1.transform.position, point2.transform.position);
        float player1LengthA = Vector2.Distance(player1.transform.position, point1.transform.position);
        float player1LengthB = Vector2.Distance(player1.transform.position, point2.transform.position);

        float player2LengthA = Vector2.Distance(player2.transform.position, point1.transform.position);
        float player2LengthB = Vector2.Distance(player2.transform.position, point2.transform.position);

        // Find the distance the player to the current checkpoint line
        player1DistanceFromCheckPoint = (0.5f * lengthOfCheckpoint) * Mathf.Sqrt(player1LengthA + lengthOfCheckpoint + player1LengthB);
        player2DistanceFromCheckPoint = (0.5f * lengthOfCheckpoint) * Mathf.Sqrt(player2LengthA + lengthOfCheckpoint + player2LengthB);

        // Debug

        Color color = Color.red;
        Debug.DrawLine(point1.transform.position, player1.transform.position, color);
        Debug.DrawLine(player1.transform.position, point2.transform.position, color);

        if (player1DistanceFromCheckPoint < player2DistanceFromCheckPoint)
        {
            player1RacePosition.text = "1";
            player2RacePosition.text = "2";
        }
        else
        {
            player1RacePosition.text = "2";
            player2RacePosition.text = "1";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
