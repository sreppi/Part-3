using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public ItemBoxSpawner itemBoxSpawner;

    public void Start()
    {
        itemBoxSpawner = this.gameObject.GetComponentInParent<ItemBoxSpawner>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("ItemPickUp", SendMessageOptions.DontRequireReceiver);
        itemBoxSpawner.gameObject.SendMessage("StartItemBoxCoroutine", SendMessageOptions.DontRequireReceiver);
    }
}
