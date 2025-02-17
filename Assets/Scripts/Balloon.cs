using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{

    //declaring a float for the balloon's speed
    public float balloonSpeed = 1f;
    //setting the lifetime of the balloon which can be used for destroying gameobject
    float lifetime = 3f;
    //setting the starting duration of the timer
    float timer = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //THis piece of code makes the balloon float up.
        transform.Translate(Vector3.up * balloonSpeed * Time.deltaTime);

       
        //This is code for a timer, and destroys the object in 3 seconds.
        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
   
    
}
