using UnityEngine;

public class Movimetacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        { 
            transform.Translate(0,0,0.02f);
        }  

        if (Input.GetKey("a"))
        { 
            transform.Translate(0,0,-0.02f);
        }    

         if (Input.GetKey("w"))
        { 
            transform.Translate(0,0.05f,0);
        }  

          if (Input.GetKey("s"))
        { 
            transform.Translate(0.05f,0,0);
        } 

        physics.CheckSphere(transform.position, 1f);
    }
}
