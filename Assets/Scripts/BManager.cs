using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BManager : MonoBehaviour
{
    //Both are declared so they can be used in the function to spawn balloons.
    public GameObject balloon;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //instantiates a balloon - this function is for a button
    public void SpawnBalloon()
    {
        Instantiate(balloon, spawn);
    }
}
