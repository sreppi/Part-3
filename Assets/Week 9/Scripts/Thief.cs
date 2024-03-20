using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float dashSpeed = 7;
    //float timer;
    //public float dashTime = 2;
    //bool isDashing;
    protected override void Attack()
    {
        StartCoroutine(Dash()); // or StartCoroutine("Dash");
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        while ( speed > 3 )
        {
            yield return null;
        }

        base.Attack();

        yield return new WaitForSeconds(0.15f);
        Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.15f);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    public override string ToString()
    {
        return "Hi I'm Bob!";
    }
}
