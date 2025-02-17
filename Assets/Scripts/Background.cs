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
    public void ChangeToBlue ()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(0.3f, 0.8f, 1f);
        
    }
    public void ChangeToBlack()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.black;
        
    }
}
