using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static int playerScore1=0;
    static int playerScore2=0;
    [SerializeField]
    GUISkin theSkin;

    Transform theBall;
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball").transform;
    }
    // Start is called before the first frame update
    public static void Score(string wallName)
    {
        if(wallName == "RightWall")
        {
            playerScore1+=1;
        }
        else if(wallName == "LeftWall")
        {
            playerScore2+=1;
        }
        //print("Score Increased");
    }
    public void OnGUI()
    {
        GUI.skin=theSkin;
        GUI.Label(new Rect(Screen.width/2-150,20,100,100),""+playerScore1);
        GUI.Label(new Rect(Screen.width/2+150,20,100,100),""+playerScore2);

        if(GUI.Button(new Rect(Screen.width/2 -121/2,35,121,53),"RESET"))
        {
            playerScore1 =0;
            playerScore2 =0;
            theBall.gameObject.SendMessage("ResetBall");
        }
    }
    
}
