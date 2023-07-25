using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string point;
    
    public void EndGame()
    {
        
        point = FindObjectOfType<score>().pts;
        point = "FINAL SCORE IS " + point;

        FindObjectOfType<score>().FinalScore(point);

        FindObjectOfType<score>().enabled = false;
        FindObjectOfType<PlayerMotion>().enabled = false;
        Invoke("restart", 5);
        
    }
    void restart()
    {
        FindObjectOfType<score>().enabled = true;
        FindObjectOfType<PlayerMotion>().PositionReset();
        FindObjectOfType<PlayerMotion>().enabled = true;
        FindObjectOfType<score>().ReScore();
    }
}
