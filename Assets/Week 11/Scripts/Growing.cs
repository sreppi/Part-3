using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class Growing : MonoBehaviour
{
    public GameObject square;
    public GameObject triangle;
    public GameObject circle;
    public bool circleLoop;
    public TextMeshProUGUI squareTMP;
    public TextMeshProUGUI triangleTMP;
    public TextMeshProUGUI circleTMP;
    public TextMeshProUGUI crTMP;
    public int running;
    Coroutine coroutine;

    void Start()
    {
        StartCoroutine(GrowingShapes());
        circleLoop = true;
    }

    void Update()
    {
        crTMP.text = "Couroutines: " + running.ToString();
    }

    IEnumerator GrowingShapes()
    {
        running += 1;
        StartCoroutine(Square());
        yield return new WaitForSeconds(1);
        coroutine = StartCoroutine(Triangle());
        yield return coroutine; // When this is null, basically (Not quite but that's how you think about it)
        StartCoroutine(CircleLooping());
        running -= 1;
    }

    IEnumerator CircleLooping()
    {
        while (circleLoop == true)
        {
            StartCoroutine(Circle());
            yield return new WaitForSeconds(10); // This is a pretty jank method
            yield return null;
        }
    }

    IEnumerator Square()
    {
        running += 1;
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            square.transform.localScale = scale;
            squareTMP.text = "Square: " + scale;
            yield return null;
        }
        running -= 1;
    }
    IEnumerator Triangle()
    {
        running += 1;
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            triangle.transform.localScale = scale;
            triangleTMP.text = "Triangle: " + scale;
            yield return null;
        }
        running -= 1;
    }
    IEnumerator Circle()
    {
        running += 1;
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
            yield return null;
        }
        running -= 1;
        running += 1;
        while (size > 0)
        {
            size -= Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
            yield return null;
        }
        running -= 1;
    }
}
