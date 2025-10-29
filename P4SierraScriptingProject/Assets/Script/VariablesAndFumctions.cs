using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFumctions : MonoBehaviour
{
    //create my interger varieble
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
       //run my variable thru my function
       myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //create the multibly by two function
    int MultiplyByTwo(int number)
        
    {
        // Update is called once per frame
        int result;
        
        //multiplying the num,ber by two
        result = *2;
        
        //return the value
        return result;
    }
}
