using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Building : MonoBehaviour
{
    
    public float interpolation;
    public AnimationCurve animationCurve;
    public GameObject well;
    public GameObject logs;
    public GameObject logChair;
    public float lerpTimer;
    public Vector3 scaleChange = new Vector3(0, 1f, 0);
    public float speed;

    private void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
        well.transform.localScale = new Vector3(1, 0, 1);
        logs.transform.localScale = new Vector3(1, 0, 1);
        logChair.transform.localScale = new Vector3(1, 0, 1);
        StartCoroutine(Grow());
    }
    IEnumerator Grow()
    {
        while (well.transform.localScale.y < 1)
        {
            //interpolation = animationCurve.Evaluate(lerpTimer);
            well.transform.localScale -= scaleChange * (speed * Time.deltaTime);
            yield return null;
        }

        while (logs.transform.localScale.y < 1)
        {
            //interpolation = animationCurve.Evaluate(lerpTimer);
            logs.transform.localScale -= scaleChange * (speed * Time.deltaTime);
            yield return null;
        }

        while (logChair.transform.localScale.y < 1)
        {
            //interpolation = animationCurve.Evaluate(lerpTimer);
            logChair.transform.localScale -= scaleChange * (speed * Time.deltaTime); // I don't know how to convert this into lerp... 
            yield return null;
        }
    }
}
