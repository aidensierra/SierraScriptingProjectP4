using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convention & Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is to tell me the x position of my object
        Debug.Log(trtansform.position.x);


    }

    // Update is called once per frame
    void Update()
{
    if (transform.position.y <= 5f)
    {
        Debug.Log("I'm about to hit the ground!");
    }
} 
}
