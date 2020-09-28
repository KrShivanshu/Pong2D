using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [SerializeField] 
    Camera mainCam;
    [SerializeField] 
    BoxCollider2D topWall;
    [SerializeField] 
    BoxCollider2D bottomWall;
    
    [SerializeField] 
    BoxCollider2D leftWall;
    [SerializeField] 
    BoxCollider2D rightWall;
    
    [SerializeField]
    Transform player1;
    [SerializeField]
    Transform player2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width*2f,0f,0f)).x,1f);
        topWall.offset = new Vector2(0f,mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y + 0.5f);


        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width*2f,0f,0f)).x,1f);
        bottomWall.offset = new Vector2(0f,mainCam.ScreenToWorldPoint(new Vector3(0f,0f,0f)).y - 0.5f);

        leftWall.size = new Vector2(1f,mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height*2f,0f)).y);
        leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f,0f,0f)).x - 0.5f,0f);
        
        rightWall.size = new Vector2(1f,mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height*2f,0f)).y);
        rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x + 0.5f,0f);

       // player1.transform.position=mainCam.ScreenToWorldPoint(new Vector3(75f,Screen.height*0.5f,0f));
        //player2.transform.position=mainCam.ScreenToWorldPoint(new Vector3(Screen.width-75f,Screen.height*0.5f,0f));
    }
}
