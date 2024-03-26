using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    protected float acceleration;
    protected float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    public Rigidbody2D rb;
    float maxSpeed = 500;
    float timer = 0;
    public bool oilItem = false;
    public GameObject oilSpillPrefab;

    // Checkpoint System

    public int currentLap = 1;
    public int nextCheckpoint = 1;
    public GameObject point1;
    public GameObject point2;
    public GameObject player;
    public float playerDistanceFromCheckPoint;

    void Start()
    {
        point1 = GameObject.FindWithTag("PointA1");
        point2 = GameObject.FindWithTag("PointA2");
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        playerControls();
        playerItemControls();
    }
    public void FixedUpdate()
    {
        rb.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if(rb.velocity.magnitude < maxSpeed) // Max Speed
        {
            rb.AddForce(force);
        }

        float lengthOfCheckpoint = Vector2.Distance(point1.transform.position, point2.transform.position);
        float player1LengthA = Vector2.Distance(player.transform.position, point1.transform.position);
        float player1LengthB = Vector2.Distance(player.transform.position, point2.transform.position);

        // Find the distance the player to the current checkpoint line
        playerDistanceFromCheckPoint = (0.5f * lengthOfCheckpoint) * Mathf.Sqrt(player1LengthA + lengthOfCheckpoint + player1LengthB);

        // Debug

        Color color = Color.red;
        Debug.DrawLine(point1.transform.position, player.transform.position, color);
        Debug.DrawLine(player.transform.position, point2.transform.position, color);
    }

    protected virtual void playerControls()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
    protected virtual void playerItemControls()
    {
        if (oilItem == true && Input.GetKeyDown("/"))
        {
            Instantiate(oilSpillPrefab, rb.transform.position - (rb.transform.up * 2f), Quaternion.identity);
            oilItem = false;
        }
    }
public void OilSlip()
    {
        StartCoroutine(PlayerSlip());
    }

    IEnumerator PlayerSlip()
    {
        while(timer < 1)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            rb.transform.Rotate(0, 0, 1f);
            yield return null;
        }
        timer = 0;
        yield return null;
    }

    public void ItemPickUp()
    {
        oilItem = true;
        Debug.Log("A player has picked up an item!");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "CheckpointA" && nextCheckpoint == 1)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointB1");
            point2 = GameObject.FindWithTag("PointB2");
        }

        if (collision.gameObject.tag == "CheckpointB" && nextCheckpoint == 2)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointC1");
            point2 = GameObject.FindWithTag("PointC2");
        }
        if (collision.gameObject.tag == "CheckpointC" && nextCheckpoint == 3)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointD1");
            point2 = GameObject.FindWithTag("PointD2");
        }

        if (collision.gameObject.tag == "CheckpointD" && nextCheckpoint == 4)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointE1");
            point2 = GameObject.FindWithTag("PointE2");
        }

        if (collision.gameObject.tag == "CheckpointE" && nextCheckpoint == 5)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointF1");
            point2 = GameObject.FindWithTag("PointF2");
        }

        if (collision.gameObject.tag == "CheckpointF" && nextCheckpoint == 6)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointG1");
            point2 = GameObject.FindWithTag("PointG2");
        }

        if (collision.gameObject.tag == "CheckpointG" && nextCheckpoint == 7)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointH1");
            point2 = GameObject.FindWithTag("PointH2");
        }

        if (collision.gameObject.tag == "CheckpointH" && nextCheckpoint == 8)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointI1");
            point2 = GameObject.FindWithTag("PointI2");
        }

        if (collision.gameObject.tag == "CheckpointI" && nextCheckpoint == 9)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointJ1");
            point2 = GameObject.FindWithTag("PointJ2");
        }

        if (collision.gameObject.tag == "CheckpointJ" && nextCheckpoint == 10)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointK1");
            point2 = GameObject.FindWithTag("PointK2");
        }

        if (collision.gameObject.tag == "CheckpointK" && nextCheckpoint == 11)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointL1");
            point2 = GameObject.FindWithTag("PointL2");
        }

        if (collision.gameObject.tag == "CheckpointL" && nextCheckpoint == 12)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointM1");
            point2 = GameObject.FindWithTag("PointM2");
        }

        if (collision.gameObject.tag == "CheckpointM" && nextCheckpoint == 13)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointN1");
            point2 = GameObject.FindWithTag("PointN2");
        }

        if (collision.gameObject.tag == "CheckpointN" && nextCheckpoint == 14)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointO1");
            point2 = GameObject.FindWithTag("PointO2");
        }

        if (collision.gameObject.tag == "CheckpointO" && nextCheckpoint == 15)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointP1");
            point2 = GameObject.FindWithTag("PointP2");
        }

        if (collision.gameObject.tag == "CheckpointP" && nextCheckpoint == 16)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointQ1");
            point2 = GameObject.FindWithTag("PointQ2");
        }

        if (collision.gameObject.tag == "CheckpointQ" && nextCheckpoint == 17)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointR1");
            point2 = GameObject.FindWithTag("PointR2");
        }

        if (collision.gameObject.tag == "CheckpointR" && nextCheckpoint == 18)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointS1");
            point2 = GameObject.FindWithTag("PointS2");
        }

        if (collision.gameObject.tag == "CheckpointS" && nextCheckpoint == 19)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointT1");
            point2 = GameObject.FindWithTag("PointT2");
        }

        if (collision.gameObject.tag == "CheckpointT" && nextCheckpoint == 20)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointU1");
            point2 = GameObject.FindWithTag("PointU2");
        }

        if (collision.gameObject.tag == "CheckpointU" && nextCheckpoint == 21)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointV1");
            point2 = GameObject.FindWithTag("PointV2");
        }

        if (collision.gameObject.tag == "CheckpointV" && nextCheckpoint == 22)
        {
            nextCheckpoint += 1;
            point1 = GameObject.FindWithTag("PointW1");
            point2 = GameObject.FindWithTag("PointW2");
        }

        if (collision.gameObject.tag == "CheckpointW" && nextCheckpoint == 23)
        {
            currentLap += 1;
            nextCheckpoint = 1;
            point1 = GameObject.FindWithTag("PointA1");
            point2 = GameObject.FindWithTag("PointA2");
        }
    }
}
