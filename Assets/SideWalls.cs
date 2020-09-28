using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GetComponent<AudioSource>().Play();
            ScoreManager.Score(wallName);
            hitInfo.gameObject.SendMessage ("ResetBall");
        }
    }
}
