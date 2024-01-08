using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateSphere : MonoBehaviour
{
    public float speed = 2f;
    private float timer = 0f;
    private bool moveRight = true;

    private void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if (timer >= 1.7f)
        {
            moveRight = !moveRight;

            timer = 0f;
        }
    }
}
