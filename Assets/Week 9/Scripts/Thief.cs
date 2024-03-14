using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();

        if (Input.GetMouseButtonDown(1) && isSelected && !clickingOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButtonDown(1) && isSelected)
        {
            Move();
        }

        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
