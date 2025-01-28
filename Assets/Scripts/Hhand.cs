using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hhand : MonoBehaviour
{
    // Start is called before the first frame update
    public float hourHand = 1f;
    public AudioClip clip;
    public AudioSource audioS;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 rot = transform.eulerAngles;
        rot.z += hourHand;
        transform.eulerAngles = rot; 
        //if(rot.z == -360)
        //{
         //   rot.z = 0;
        //}
            
        if (rot.z % 30 == 0)
        {
            Debug.Log("Now");
            audioS.PlayOneShot(clip);
        }
        
    }

 } 
