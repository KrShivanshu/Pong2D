using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    KeyCode moveUp;
    [SerializeField]
    KeyCode moveDown;
    [SerializeField] 
    float speed=10;
    // Update is called once per frame
    
    void Update()
    {
        Vector3 v = GetComponent<Rigidbody2D>().velocity;
        v.x=0;
        if(Input.GetKey(moveUp))
        {
        
        v.y = speed;
        GetComponent<Rigidbody2D>().velocity = v;
            
        }
        else if(Input.GetKey(moveDown))
        {
            
        v.y = speed*-1;
        GetComponent<Rigidbody2D>().velocity = v;
        }
        else
        {
        
        v.y = 0;
        GetComponent<Rigidbody2D>().velocity = v;
        }
        
    }
}
