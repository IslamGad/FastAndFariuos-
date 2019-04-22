using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTheCar : MonoBehaviour
{
    public Transform car_1;    // A variable that stores a reference to our Player
    public Vector3 offset;      // A variable that allows us to offset the position (x, y, z)

    // Update is called once per frame
    void Update()
    {
        // Set our position to the players position and offset it
        transform.position = car_1.position + offset;
       //  transform.eulerAngles = new Vector3(car_1.position.x + offset.x, car_1.position.y + offset.y, car_1.position.z + offset.z);

       

    }
}
