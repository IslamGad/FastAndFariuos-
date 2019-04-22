using System.Collections;
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
    cubesPivotDistance = cubeSize * cubesInRow / 2;
        //use this value to create pivot vector)
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
        //make object disappear
        gameObject.SetActive(false);
        //loop 3 times to create 5x5x5 pieces in x,y,z coordinates
        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    GameObject piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

                    //set piece position and scale

                    piece.transform.position = gameObject.transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
                    piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

                    //add rigidbody and set mass
                    piece.AddComponent<Rigidbody>();
                    piece.GetComponent<Rigidbody>().mass = cubeSize;
                }
            }
        }
        


    }
 

}