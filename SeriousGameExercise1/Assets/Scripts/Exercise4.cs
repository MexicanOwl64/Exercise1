﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public Material transparencyPrefab;
    // Update is called once per frame
    void FixedUpdate()
    {
        //To create a Gaussian distribution in Unity we can actually use Random.Range() on two separate Random.Ranges
        float num = Random.Range(Random.Range(-10, 10), Random.Range(-10, 10));
        float sd = 30;
        float mean = 5;

        float x = Random.Range(-10, 10);
        float y = Random.Range(0, 20);
        float z = Random.Range(5, 15);
        
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Renderer r = sphere.GetComponent<Renderer>();
        sphere.GetComponent<SphereCollider>().enabled = false;
        Object.Destroy(sphere.GetComponent<SphereCollider>());
        r.material = transparencyPrefab;

        //This sets our ink "sphere game objects" at the position of the Walker GameObject (walkerGO) at the current frame
        //to draw the path
        sphere.transform.position = new Vector3(x, y, z);
    }

   

}
