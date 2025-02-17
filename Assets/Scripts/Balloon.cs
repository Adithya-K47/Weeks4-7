using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    public float balloonSpeed = 1f;
    float lifetime = 3f;
    float timer = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.up * balloonSpeed * Time.deltaTime);

        if (transform.position.y > 7)
        {
            Destroy(gameObject);
        }

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
   
    
}
