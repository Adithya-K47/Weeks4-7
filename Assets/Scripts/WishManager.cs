using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WishManager : MonoBehaviour
{
    public GameObject birthdaycard;
    public GameObject newyearcard;
    float min = 0.001f;
    float max = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BirthdayButton()
    {
        birthdaycard.transform.localScale = new Vector3(max, max, max);
        newyearcard.transform.localScale = new Vector3(min, min, min);
    }
    public void NewYearButton()
    {
        birthdaycard.transform.localScale = new Vector3(min,min,min);
        newyearcard.transform.localScale = new Vector3(max,max,max);
    }
}
