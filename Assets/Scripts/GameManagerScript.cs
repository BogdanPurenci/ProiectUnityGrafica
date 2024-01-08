using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject spherePrefab;

    private void Start()
    {
        if (spherePrefab == null)
        {
            Debug.LogError("Sphere prefab is not assigned!");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnSpheres();
        }
    }

    public void SpawnSpheres()
    {
        GameObject sphere1 = Instantiate(spherePrefab, new Vector3(-7.52f, 0.41f, -0.6f), Quaternion.identity);
        GameObject sphere2 = Instantiate(spherePrefab, new Vector3(-14.87f, 0.41f, -0.93f), Quaternion.identity);

        sphere1.tag = "Ghost";
        sphere2.tag = "Ghost";

        sphere1.AddComponent<SphereCollider>();
        sphere2.AddComponent<SphereCollider>();

        sphere1.AddComponent<TranslateSphere>();
        sphere2.AddComponent<RotateScaleSphere>();
    }
}
