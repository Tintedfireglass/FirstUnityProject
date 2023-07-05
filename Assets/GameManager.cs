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
    }
    void restart()
    {

    }
}
