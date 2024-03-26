using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSpill : MonoBehaviour

{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter oil.");
        collision.gameObject.SendMessage("OilSlip", SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
