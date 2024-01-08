using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScaleSphere : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float scaleSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        float scaleFactor = Mathf.PingPong(Time.time * scaleSpeed, 1f) + 1f;
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
}
