using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //This function gets the spriterenderer component so the color of the sky can change to blue (afternoon)
    public void ChangeToBlue ()
    {
        //getting the componenent
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        //setting the color to blue
        sr.color = new Color(0.3f, 0.8f, 1f);
        
    }

    //This function gets the spriterenderer component so the color of the sky can change to black (night)
    public void ChangeToBlack()
    {
        //getting the componenent
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        //setting the color to black
        sr.color = Color.black;
        
    }
}
