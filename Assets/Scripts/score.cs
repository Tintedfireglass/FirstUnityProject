using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class score : MonoBehaviour
{
    public TMP_Text scorecard;
    public Transform player;
    public string pts;
    int strt ;
    void Start()
    {
       strt = (int)player.position.z;
       
    }

    // Update is called once per frame
    void Update()
    {
        scorecard.text = ((int)player.position.z - strt).ToString();
        pts = scorecard.text;
        Debug.Log("Score Updated");
  
    }
    public void FinalScore(string pt)
    {
        scorecard.text = pt;
    }
    public void ReScore()
    {
        scorecard.text = "0";
    }
}
