using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3 : Car
{
    float stuckTimer = 0;
    protected override void playerControls()
    {
        acceleration = 1;

        // When the automated car gets stuck (Which will happen alot LOL)
        while (rb.velocity.magnitude < 0.1)
        {
            stuckTimer += Time.deltaTime;
            if (stuckTimer >= 5)
            {
                rb.transform.position = new Vector3(0.57f, -9.48f, 0);
                rb.transform.rotation = Quaternion.Euler(0, 0, 90);
                stuckTimer = 0;
                nextCheckpoint = 1;
                steering = 0;
            }
            return;
        }

        // Super Jank Automated Car Control
        while (nextCheckpoint == 2)
        {
            steering = 0.3f;
            return;
        }
        while (nextCheckpoint == 3)
        {
            steering = 0.1f;
            return;
        }
        while (nextCheckpoint == 4)
        {
            steering = 0;
            return;
        }
        while (nextCheckpoint == 5)
        {
            steering = 0.5f;
            return;
        }
        while (nextCheckpoint == 6)
        {
            steering = 0f;
            return;
        }
        while (nextCheckpoint == 7)
        {
            steering = 0.35f;
            return;
        }
        while (nextCheckpoint == 8)
        {
            steering = -0.15f;
            return;
        }
        while (nextCheckpoint == 9)
        {
            steering = -0.2f;
            return;
        }
        while (nextCheckpoint == 10)
        {
            steering = -0.15f;
            return;
        }
        while (nextCheckpoint == 11)
        {
            steering = -0.35f;
            return;
        }
        while (nextCheckpoint == 12)
        {
            steering = -0.1f;
            return;
        }
        while (nextCheckpoint == 13)
        {
            steering = 0;
            return;
        }
        while (nextCheckpoint == 14)
        {
            steering = 0.25f;
            return;
        }
        while (nextCheckpoint == 15)
        {
            steering = 0;
            return;
        }
        while (nextCheckpoint == 17)
        {
            steering = 0.4f;
            return;
        }
        while (nextCheckpoint == 18)
        {
            steering = -0.01f;
            return;
        }
        while (nextCheckpoint == 20)
        {
            steering = 0f;
            return;
        }
        while (nextCheckpoint == 21)
        {
            steering = 0.5f;
            return;
        }
        while (nextCheckpoint == 23)
        {
            steering = 0;
            return;
        }
    }
    protected override void playerItemControls()
    {

    }

}
