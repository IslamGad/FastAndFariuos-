using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCrach : MonoBehaviour
{
    public playerCrach movement;
      Destroy x = new Destroy();

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.name == "Cube")
        {
            
             x.explode(collisionInfo.collider.gameObject);
         }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
