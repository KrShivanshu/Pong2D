using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    float speed =100;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        
    }

    void Update()
    {
        Vector3 v = GetComponent<Rigidbody2D>().velocity;
        float xVel  = v.x;
        if(xVel < 18 && xVel > -18 && xVel!=0)
        {
            if(xVel>0)
            {
                v.x = 20;
            }
            else 
            {
                v.x= -20;
            }
            GetComponent<Rigidbody2D>().velocity = v;
        //print("vel"+xVel);
        //print("vel"+v.x);
        }
        

    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2.0f);
        GoBall();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Player")
        {
            Vector3 v = GetComponent<Rigidbody2D>().velocity;
        v.y=v.y/2+col.collider.GetComponent<Rigidbody2D>().velocity.y/3;
        GetComponent<Rigidbody2D>().velocity = v;
        GetComponent<AudioSource>().pitch =Random.Range(0.8f,1.2f);
        GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator ResetBall()
    {
        Vector3 v = GetComponent<Rigidbody2D>().velocity;
        v.x=0;
        v.y=0;
        GetComponent<Rigidbody2D>().velocity = v;
        Vector3 position = transform.position;
        position.x=0;
        position.y=0;
        transform.position = position;

        yield return new WaitForSeconds(2.0f);
        GoBall();
    }

    void GoBall()
    {
        int dir=Random.Range(0,2);
        if(dir<=0.5)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2 (speed,10));
        }
        else 
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2 (-speed,-10));
        }
    }
}
