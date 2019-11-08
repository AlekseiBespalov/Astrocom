using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToCamera : MonoBehaviour
{
    public GameObject text;

    public float DistanceToOff;

    private float DistanceToText;

    private void DistanceToTextUpdate()
    {
        var Dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        DistanceToText = Dist;
    }
    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(Vector3.up - new Vector3(0, 180, 0));
        DistanceToTextUpdate();
        CheckDistanceToText();
    }
    private void CheckDistanceToText()
    {
        if(DistanceToText <= DistanceToOff)
        {
            text.SetActive(false);
        }
        else if(DistanceToText > DistanceToOff)
        {
            text.SetActive(true);
        }
    }
}
