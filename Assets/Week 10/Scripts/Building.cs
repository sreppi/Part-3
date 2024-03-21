using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Building : MonoBehaviour
{
    Vector3 scale = new Vector3(0, 1, 1);
    IEnumerator Grow()
    {
        Debug.Log("Building...");
        transform.localScale = scale;
        while (transform.localScale.x < 2)
        {
            Debug.Log("Scale is" + scale.x);
            scale.x += 0.5f;
            yield return null;
        }
        Debug.Log("Finished building.");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(Grow());
        }
    }
}
