using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : Car
{

    protected override void playerControls()
    {
        acceleration = Input.GetAxis("Vertical P2");
        steering = Input.GetAxis("Horizontal P2");
    }
    protected override void playerItemControls()
    {
        if (oilItem == true && Input.GetKeyDown("e"))
        {
            Instantiate(oilSpillPrefab, rb.transform.position - (rb.transform.up * 2f), Quaternion.identity);
            oilItem = false;
        }
    }
}
