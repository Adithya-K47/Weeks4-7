using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WishManager : MonoBehaviour
{
    //getting reference to gameobjects so i can change their scale later
    public GameObject birthdaycard;
    public GameObject newyearcard;
    //declaring floats so i can change it to these values when functions are called
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


    //This function changes the scale of the the primary greeting so it can be seen and the other one is made smaller so it cant be seen.
    public void BirthdayButton()
    {
        birthdaycard.transform.localScale = new Vector3(max, max, max);
        newyearcard.transform.localScale = new Vector3(min, min, min);
    }
    //THis does the same as the functon above, but just vice versa.
    public void NewYearButton()
    {
        birthdaycard.transform.localScale = new Vector3(min,min,min);
        newyearcard.transform.localScale = new Vector3(max,max,max);
    }
}
