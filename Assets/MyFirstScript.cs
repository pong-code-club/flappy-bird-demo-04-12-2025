using System;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // This is the Start function
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Crystal and Benny!");
    }
    // This is the Update function
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Inside Update");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressing Up Button");
        }
    }
}
