﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

  
    // Use this for initialization
    void Start()
    {


        //calculate pivot distance
      //  cubesPivotDistance = cubeSize * cubesInRow / 2;
        //use this value to create pivot vector)
       // cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private void OnTriggerEnter(Collider other)
    {
         
          

    }

    public void explode(GameObject gameObject)
    {
             float cubeSize = 0.6f;
     int cubesInRow = 2;

    float cubesPivotDistance;
    Vector3 cubesPivot;

     float explosionForce = 50f;
     float explosionRadius = 4f;
     float explosionUpward = 0.4f;
    //calculate pivot distance
    cubesPivotDistance = cubeSize * cubesInRow / 5;
        //use this value to create pivot vector)
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
        //make object disappear
        gameObject.SetActive(false);
        //loop 3 times to create 5x5x5 pieces in x,y,z coordinates
        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                GameObject piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

                for (int z = 0; z < cubesInRow; z++)
                {
                  

                    //set piece position and scale

                    piece.transform.position = gameObject.transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
                    piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

                    //add rigidbody and set mass
                    piece.AddComponent<Rigidbody>();
                    piece.GetComponent<Rigidbody>().mass = cubeSize;
                }
             
            }
         
        }
        /*
        //get explosion position
        Vector3 explosionPos = transform.position;
        //get colliders in that position and radius
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        //add explosion force to all colliders in that overlap sphere
        foreach (Collider hit in colliders)
        {
            //get rigidbody from collider object
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                //add explosion force to this body with given parameters
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }
        */


    }
 

}