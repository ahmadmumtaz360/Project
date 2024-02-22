using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key is pressed");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            print("space key is continue down");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("space key is released");
        }





        if (Input.GetButtonDown("Fire1"))
        {
            print("A key is pressed");
        }
        if (Input.GetButton("Fire1"))
        {
            print("A key is continue down");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            print("A key is released");
        }
    }
}
