using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int cupsInTheSick = 4;
    // Start is called before the first frame update
    void Start()
    {
        while (cupsInTheSick > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSick--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
