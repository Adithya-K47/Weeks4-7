using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BManager : MonoBehaviour
{
    public GameObject balloon;
    public Transform spawn;
    public Button spawnerbutton;
    public Slider speed;
    public float basespeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBalloon()
    {
        Instantiate(balloon, spawn);
    }
}
